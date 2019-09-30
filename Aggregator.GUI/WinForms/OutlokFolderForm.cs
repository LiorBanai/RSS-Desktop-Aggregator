using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.Data;
using Aggregator.Util;
using Microsoft.Office.Interop.Outlook;

namespace Aggregator.GUI.WinForms
{
    public partial class OutlokFolderForm : Form
    {
        #region Data Members
        //TODO
        //private OutlookConnection OutlookConnection { get; set; }

        #endregion

        #region Ctor

        public OutlokFolderForm()
        {
            InitializeComponent();
            //TODO
          //  OutlookConnection = new OutlookConnection();

        }

        #endregion

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //TODO
            //foreach (Folder folder in OutlookConnection.Allfolders)
            //{
            //    BuildFoldersTree(folder, null);
            //}
            //tvOutlookFolders.ExpandAll();
        }


        private void BuildFoldersTree(MAPIFolder folder, TreeNode rootNode)
        {
            if (folder.DefaultItemType == OlItemType.olMailItem)
            {
                TreeNode nodeitem = new TreeNode(folder.Name);
                nodeitem.Checked = true;
                nodeitem.Tag = folder.EntryID;
                if (rootNode == null)
                {
                    tvOutlookFolders.Nodes.Add(nodeitem);
                }
                else
                {
                    rootNode.Nodes.Add(nodeitem);
                }

                Folders subfolders = folder.Folders;
                foreach (Folder subfolder in subfolders)
                {
                    BuildFoldersTree(subfolder, nodeitem);
                }
            }

        }

        private void tvOutlookFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
            {
                string foldername = e.Node.Name;
                string folderid = e.Node.Tag.ToString();
                //TODO
                //MAPIFolder currentfolder = OutlookConnection.NameSpace.GetFolderFromID(folderid);
                /*if (bwFillItems.IsBusy)
                    bwFillItems.CancelAsync();
                while (bwFillItems .IsBusy)*/
                
                //GetAllItemsFromFolder(dgvAllItems, currentfolder);
            }
        }

        private void GetAllItemsFromFolder(Control control, MAPIFolder folder)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => GetAllItemsFromFolder(control, folder)));
            }
            else if (folder.DefaultItemType == OlItemType.olMailItem)
            {
                MailItem item = null;
                // dgvAllItems.Rows.Clear();
                try
                {

                    tsslName.Text = string.Format("Folder Name: {0}, EntryId: {1}", folder.Name, folder.EntryID);
                    tsslItemsCount.Text = string.Format("Num Items: {0}", folder.Items.Count.ToString());
                    dgvAllItems.SuspendLayout();
                    //TODO
                    //List<MyOutlookItem > items = OutlookConnection.GetAllItemsInSpecificFolder(folder);
                    //// dgvAllItems.Rows.Add(i, item.Subject,
                    ////     string.Format("Sent: {0} {1}", item.SentOn.ToLongDateString(), item.SentOn.ToLongTimeString()));

                    //dgvAllItems.DataSource = items;
                    //dgvAllItems.DataMember = "MailItem";
                    dgvAllItems.ResumeLayout();
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    MessageShow.ShowException(this, ex);
                }
                finally
                {

                }

            }
        }

        private void dgvAllItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllItems .CurrentRow !=null)
            {
                MyOutlookItem currentitem =(MyOutlookItem) dgvAllItems.CurrentRow.DataBoundItem;
                dynamic item = currentitem.OutlookMailItem;
                item.Display();
            }
        }
    }
}
