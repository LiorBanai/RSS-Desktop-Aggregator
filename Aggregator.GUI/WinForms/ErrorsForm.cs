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
    public partial class ErrorsForm : Form
    {
        private StringBuilder str;

        public ErrorsForm()
        {
            InitializeComponent();
            str = new StringBuilder();
        }

        public void AddError(string error)
        {
            str.Append(DateTime.Now + ": "+ error);
            ShowErrors();
        }

        private void ShowErrors()
        {
            if (Visible)
            {
                if (rtxblogs.InvokeRequired)
                {
                    rtxblogs.BeginInvoke(new MethodInvoker(ShowErrors));
                }
                else
                {
                    lock (str)
                    { rtxblogs.Text = str.ToString();}
                    rtxblogs.SelectionStart = rtxblogs.Text.Length;
                }
            }

        }

        private void Errors_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void ErrorsForm_VisibleChanged(object sender, EventArgs e)
        {
            ShowErrors() ;
        }
          
        
    }
}
