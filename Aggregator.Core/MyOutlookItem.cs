using System.Reflection;
using Aggregator.Util;

namespace Aggregator.Core
{
	public class MyOutlookItem
	{
		#region Data Members

		public object OutlookMailItem;
		public string Folder { get; private set; }
		public int Index { get; private set; }
		public string Subject
		{
			get
			{
				if (OutlookMailItem != null)
					try
					{
						return ((dynamic)OutlookMailItem).Subject;
					}
					catch (System.Exception ex)
					{
						MessageShow.ShowException(this, ex,true);
						OutlookMailItem = null;
						return string.Empty;
					}
				return string.Empty;
			}
		}



		#endregion

		#region Ctor

		public MyOutlookItem(object itm, int id, string folder)
		{
			OutlookMailItem = itm;
			Index = id;
			Folder = folder;
		}

		#endregion

		#region Methods
	
		public  bool HasMethod(string methodName)
		{
			var type = OutlookMailItem.GetType();
			return type.GetMethod(methodName) != null;
		} 
		public void RunMethod(string methodName)
		{
			var dynamicItem = OutlookMailItem as dynamic ;
			try
			{
				if (methodName.ToLower().Equals("display"))
					dynamicItem.Display();
				else if (methodName.ToLower().Equals("delete"))
					dynamicItem.Delete();
                else if (methodName.ToLower().Equals("reply"))
                {
                    var response = dynamicItem.Reply();
                    response.Display();
                }
			}
			catch (System.Exception ex)
			{
				MessageShow.ShowException(this, ex);
			}          
			
		}
		public void SetProperty(string propertyName,object value)
		{
			var dynamicItem = OutlookMailItem as dynamic;

			try
			{
				if (propertyName.ToLower().Equals("unread"))
					dynamicItem.Unread = value;
	}
			catch (System.Exception ex)
			{
				MessageShow.ShowException(this, ex);
			}  
		}
		#endregion
	}
}
