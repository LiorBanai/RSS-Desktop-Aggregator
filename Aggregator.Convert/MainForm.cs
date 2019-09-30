using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;

namespace Aggregator.Convert
{
    public partial class MainForm : Form
    {
        public string Filename { get; set; }
        private List<IRSSFeed> Feeds { get; set; }

        public int Count { get { return Feeds.Count(); } }
        private bool IsFileExist { get { return File.Exists(Filename); } }
        public IRSSFeed this[int id] { get { return Feeds[id]; } }

        public MainForm()
        {
            InitializeComponent();
            Filename = "rss feeds.dat";
        }




        public void SerializeToBinaryFile()
        {
            Utils.SerializeToBinaryFile(Feeds, Filename, false);
        }

        public void DeSerializeBinaryFile()
        {
            Feeds = Utils.DeSerializeBinaryFile<IRSSFeed>(Filename, false);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            DeSerializeBinaryFile();
        }
    }
}
