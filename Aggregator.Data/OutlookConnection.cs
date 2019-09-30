using System.Collections.Generic;
using Aggregator.Core;
using Aggregator.Util;
using Microsoft.Office.Interop.Outlook;

namespace Aggregator.Data
{
    public class OutlookConnection
    {
        #region DataMembers

        private static Application App { get; set; }
        public NameSpace NameSpace { get; private set; }
        public Folders Allfolders { get; private set; }

        #endregion

        #region Ctor

        public OutlookConnection()
        {
            try
            {

                App = new ApplicationClass();
                NameSpace = App.GetNamespace("MAPI");
                Allfolders = NameSpace.Folders;

                MAPIFolder inboxFld = NameSpace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
            }
            catch (System.Exception ex)
            {
                MessageShow.ShowException(this, ex);

            }
        }

        #endregion

        public List<MyOutlookItem> GetAllItemsInSpecificFolder(MAPIFolder folder, bool unreadOnly = false)
        {
            Items relevantItems = folder.Items;
            if (unreadOnly && folder.UnReadItemCount == 0)
                return new List<MyOutlookItem>(0);
            else
                if (unreadOnly)
                    relevantItems = folder.Items.Restrict("[Unread]=true");

            List<MyOutlookItem> items = new List<MyOutlookItem>(folder.Items.Count);

            for (int i = 1; i <= relevantItems.Count; i++)
            {
                
                {
                    var item = relevantItems[i];
                   // ((ItemEvents_10_Event)item).Close += Item_Close;
       

                    MyOutlookItem itm = new MyOutlookItem(item, i, folder.Name);
                    items.Add(itm);

                }
            }
            return items;
        }

        private void Item_Close(ref bool cancel)
        {
         //   MessageShow.ShowMessage(this, "test", "tes");
        }

        public List<MyOutlookItem> GetAllUnreadItemsInFolder(MAPIFolder folder, bool inSubFoldersAlso = false)
        {
            if (!inSubFoldersAlso)
                return GetAllItemsInSpecificFolder(folder, true);
            return GetAllUnreadItemsInFolders(folder);
        }

        private List<MyOutlookItem> GetAllUnreadItemsInFolders(MAPIFolder folder)
        {
            List<MyOutlookItem> currentitems = new List<MyOutlookItem>();
            if (folder.DefaultItemType == OlItemType.olMailItem)
            {
                currentitems = GetAllItemsInSpecificFolder(folder, true);
                Folders subfolders = folder.Folders;
                foreach (Folder subfolder in subfolders)
                {
                    currentitems.AddRange(GetAllUnreadItemsInFolders(subfolder));
                }
            }
            return currentitems;
        }


    }
}
