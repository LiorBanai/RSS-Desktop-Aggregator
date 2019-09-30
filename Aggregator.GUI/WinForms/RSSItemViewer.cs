using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Util;

namespace Aggregator.GUI.WinForms
{
    public partial class RSSItemViewer : Form
    {

 
        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public  event EventHandler<RSSArgs> OnRSSItemChanged = delegate { };

        #region DataMember
        private IRSSPost Post { get; set; }
        #endregion
        
        #region Ctor

        public RSSItemViewer(IRSSPost thePost)
        {
            InitializeComponent();

            Post = thePost;
            var cancelButton = new Button();
            cancelButton.Click += ((s, e) => this.BeginInvoke((MethodInvoker)this.Close));
            CancelButton = cancelButton;

        } 
        #endregion

        #region Form Methods
        private void RSSItemViewer_Load(object sender, EventArgs e)
        {
            chkbHistory.Checked = Post.IgnorePostContentIncomparison;
            string link = string.Empty;
            if (!string.IsNullOrEmpty(Post.Link))
                link = string.Format("<a href=\"{0}\">Link</a>", Post.Link);

            Text = Post.Title;

            if (string.IsNullOrEmpty(Post.Description) && string.IsNullOrEmpty(Post.Content))
            {
                wbPostView.DocumentText = Post.Title;


            }
            else
            {
                wbPostView.DocumentText = link + " <br>" + Post.Description + "<br>" + Post.Content;

            }


            tsbntHideShowPost.Image = (Post.IgnoreThisPost) ? Properties.Resources.buttonOFF : Properties.Resources.buttonOn;
            tsbntHideShowPost.Text = (Post.IgnoreThisPost) ? "Restore post visibility " : "Hide post On Main Screen";

        }
        #endregion
        

        private void HTmlToRTF()
        {
            if (wbPostView.Document != null)
            {
                wbPostView.Document.ExecCommand("SelectAll", false, null);
                wbPostView.Document.ExecCommand("Copy", false, null);
            }
        }

        private void chkbMarkAsUnRead_Click(object sender, EventArgs e)
        {
            if (Post != null)
            {
                Post.Read = !chkbMarkAsUnRead.Checked;
                OnRSSItemChanged(this, new RSSArgs(Post));
            }
        }
        private void chkbHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (Post != null)
            {
                Post.IgnorePostContentIncomparison = chkbHistory.Checked;
                OnRSSItemChanged(this, new RSSArgs(Post));
            }
        }
        
        #region Web Browser

        private void wbPostView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wbPostView.Navigating += wbPostView_Navigating;
        }
        private void wbPostView_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            e.Cancel = true;
            TryOpenLink(wbPostView.StatusText);
            Close();
        }

        private void wbPostView_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            TryOpenLink(wbPostView.StatusText);
            Close();
        }

        private void TryOpenLink(string statusText)
        {
            string url = wbPostView.StatusText.Replace("about:", "");
            try
            {
                if (Utils.IsValidUrl(url))
                    Process.Start(url);
            }
            catch (Exception)
            {

            }
        }

        
        #endregion

        private void tsbtnSaveToHTML_Click(object sender, EventArgs e)
        {
            if (wbPostView.Document != null && wbPostView.Document.Body != null &&
                         wbPostView.Document.Body.Parent != null)
            {
                // Displays a SaveFileDialog so the user can save the list
                SaveFileDialog saveFileDialoglist = new SaveFileDialog();
                saveFileDialoglist.Filter = "HTML file|*.html";
                saveFileDialoglist.Title = "Save post to HTML";
                var result = saveFileDialoglist.ShowDialog();
                if (result == DialogResult.OK)
                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialoglist.FileName != "")
                    {
                        try
                        {

                            File.WriteAllText(saveFileDialoglist.FileName, wbPostView.Document.Body.Parent.OuterHtml,
                                              Encoding.GetEncoding(wbPostView.Document.Encoding));
                            MessageShow.ShowMessage(this,
                                                    "Post Content was saved to file:\n" +
                                                    saveFileDialoglist.FileName,
                                                    "Operation completed Successfully", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageShow.ShowException(this, ex);
                        }
                    }
            }
        }

        private void tsbntHideShowPost_Click(object sender, EventArgs e)
        {
            if (Post != null)
            {
                Post.IgnoreThisPost = !Post.IgnoreThisPost;
                tsbntHideShowPost.Image = (Post.IgnoreThisPost) ? Properties.Resources.buttonOFF : Properties.Resources.buttonOn;
                tsbntHideShowPost.Text = (Post.IgnoreThisPost) ? "Restore post visibility " : "Hide post On Main Screen";
            }
        }
    }
}
