using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aggregator.GUI.WinForms
{
    public partial class LogsForm : Form
    {
        private StringBuilder str;
        public LogsForm()
        {
            InitializeComponent();
            str = new StringBuilder();
        }

        public void AddOperation(string msg)
        {
            lock (str)
            {str.Append(msg);
               ShowLog();}
            

        }

        private void ShowLog()
        {
            if (Visible)
            {

                if (rtxbMsg.InvokeRequired)
                {
                    rtxbMsg.BeginInvoke(new MethodInvoker(ShowLog));
                }
                else
                {
                    try
                    {
 rtxbMsg.Text = str.ToString();
                   rtxbMsg.SelectionStart = rtxbMsg.Text.Length;
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                 
                }
            }
        }

        private void LogsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void LogsForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowLog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lock (str)
            {
                str.Clear();
                ShowLog();
            }
        }
          
        
    }
}
