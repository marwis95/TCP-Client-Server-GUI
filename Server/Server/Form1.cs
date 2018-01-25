﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {

            IPAddress ipAd = IPAddress.Parse("192.168.27.133");
            TcpListener myList = new TcpListener(ipAd, 8001);
            myList.Start();

            richTextBox1.AppendText("The server is running at port 8001...\n");
            richTextBox1.AppendText("The local End point is: " + myList.LocalEndpoint);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
