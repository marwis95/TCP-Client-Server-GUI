using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using komunikaty;

namespace Komunikator_Server
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private TcpListener listener = null;
        private TcpClient klient = null;
        private bool czypolaczono = false;
        private BinaryReader r = null;
        private BinaryWriter w = null;

        public void wyswietl(RichTextBox o, string tekst)
        {
            o.Focus();
            o.AppendText(tekst);
            o.ScrollToCaret();
            txtWysylanie.Focus();
        }

        private void cmdWyslij_Click(object sender, EventArgs e)
        {
            string tekst = txtWysylanie.Text;
            if (tekst == "") { txtWysylanie.Focus(); return; }
            if (tekst[tekst.Length - 1] == '\n')
                tekst = tekst.TrimEnd('\n');
            w.Write(tekst);
            wyswietl(txtOdbieranie, "===== Ja =====\n" + tekst + '\n');
            txtWysylanie.Text = "";
        }

        private void polaczenie_DoWork(object sender, DoWorkEventArgs e)
        {
            wyswietl(txtLog, "Czekam na połaczenie\n");
            listener = new TcpListener(int.Parse(txtPort.Text));
            listener.Start();
            while (!listener.Pending())
            {
                if (this.polaczenie.CancellationPending)
                {
                    if (klient != null) klient.Close();
                    listener.Stop();
                    czypolaczono = false;
                    cmdSluchaj.Text = "Czekaj na połączenie";
                    return;
                }
            }

            NetworkStream stream = klient.GetStream(); //??????????????????
            klient = listener.AcceptTcpClient();
            wyswietl(txtLog, "Zażądano połączenia\n");
            w = new BinaryWriter(stream);
            r = new BinaryReader(stream);
            if (r.ReadString() == KomunikatyKlienta.Zadaj)
            {
                w.Write(KomunikatySerwera.OK);
                wyswietl(txtLog, "Połączono\n");
                czypolaczono = true;
                cmdWyslij.Enabled = true;
                odbieranie.RunWorkerAsync();
            }
            else
            {
                wyswietl(txtLog, "Klient odrzucony\nRozlaczono\n");
                if (klient != null) klient.Close();
                listener.Stop();
                czypolaczono = false;
            }

        }

        private void odbieranie_DoWork(object sender, DoWorkEventArgs e)
        {
            string tekst;
            while ((tekst = r.ReadString()) != KomunikatyKlienta.Rozlacz)
            {
                wyswietl(txtOdbieranie, "===== Rozmówca =====\n" + tekst + '\n');
            }
            wyswietl(txtLog, "Rozlaczono\n");
            czypolaczono = false;
            klient.Close();
            listener.Stop();
            cmdSluchaj.Text = "Czekaj na połączenie";
        }

        private void txtWysylanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmdWyslij.Enabled && e.KeyChar == (char)13) cmdWyslij_Click(sender, e);
        }

        private void cmdSluchaj_Click(object sender, EventArgs e)
        {
            if (cmdSluchaj.Text == "Czekaj na połączenie")
            {
                polaczenie.RunWorkerAsync();
                cmdSluchaj.Text = "Rozłącz";
            }
            else
            {
                if (czypolaczono)
                {
                    w.Write(KomunikatySerwera.Rozlacz);
                    listener.Stop();
                    if (klient != null) klient.Close();
                    czypolaczono = false;
                }
                wyswietl(txtLog, "Rozlaczono\n");
                cmdSluchaj.Text = "Czekaj na połączenie";
                cmdWyslij.Enabled = false;
                polaczenie.CancelAsync();
                odbieranie.CancelAsync();
            }
        }

        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czypolaczono)
            {
                w.Write(KomunikatySerwera.Rozlacz);
                listener.Stop();
                if (klient != null) klient.Close();
                czypolaczono = false;
            }
            polaczenie.CancelAsync();
            odbieranie.CancelAsync();
        }
    }
}
