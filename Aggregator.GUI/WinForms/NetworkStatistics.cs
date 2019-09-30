using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Aggregator.Util;

namespace Aggregator.GUI.WinForms
{
    public partial class NetworkStatistics : Form
    {
        #region Data Members

        private IPv4InterfaceStatistics interfaceStats;
        double bytesPreviousSent, bytesCurrentSent = 0;
        double bytespreviousReceived, bytesCurrentReceived = 0;

        #endregion
        public NetworkStatistics()
        {
            InitializeComponent();

            var a = NetworkInterface.GetAllNetworkInterfaces();
            comboBox1.DataSource = a;
            comboBox1.DisplayMember = "Name";
            var nic = (NetworkInterface)comboBox1.SelectedItem;
            DisplayData(nic);
            lblDescriptionValue.Text = nic.Description;
            lblNetworkStatus.Text = nic.OperationalStatus.ToString();
            lblTypeValue.Text = nic.NetworkInterfaceType.ToString();


            comboBox1.SelectedIndexChanged += (sender, arg) =>
                                                  {
                                                      var ni = (NetworkInterface)comboBox1.SelectedItem;
                                                      DisplayData(ni);
                                                      lblDescriptionValue.Text = ni.Description;
                                                      lblNetworkStatus.Text = ni.OperationalStatus.ToString( );
                                                      lblTypeValue.Text = ni.NetworkInterfaceType.ToString();

                                                  };

        }

        public void DisplayData(NetworkInterface ni)
        {


            var stat = ni.GetIPv4Statistics();
            bytesCurrentSent = stat.BytesSent;
            bytesCurrentReceived = stat.BytesReceived;
            var KbyteSentSpeed = (bytesCurrentSent - bytesPreviousSent) / 1024.0 / (tmrStatistics.Interval / 1000.0);
            var KbytesReceivedSpeed = (bytesCurrentReceived - bytespreviousReceived) / 1024.0 / (tmrStatistics.Interval / 1000.0); ;
            lblstatDownloaded.Text = (Utils.FormatKBytes((ulong)stat.BytesReceived / 1024)) + " (Speed: " +
                                     Utils.FormatKBytes((ulong)(KbytesReceivedSpeed)) + "/s)";
            lblstatUploaded.Text = (Utils.FormatKBytes((ulong)stat.BytesSent / 1024)) + " (Speed: " +
                                   Utils.FormatKBytes((ulong)(KbyteSentSpeed)) + "/s)";

            bytespreviousReceived = bytesCurrentReceived;
            bytesPreviousSent = bytesCurrentSent;
        }

    private void tmrStatistics_Tick(object sender, EventArgs e)
        {
            DisplayData((NetworkInterface)comboBox1.SelectedItem);
        }
    }
}

