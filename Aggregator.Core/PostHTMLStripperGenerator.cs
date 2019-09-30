using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Aggregator.Core
{
  public  class PostHTMLStripperGenerator
  {
      
      private string HTMLText { get; set; }
      private string PlainText { get; set; }

 

      public string GetPlainText(string htmlcode)
      {
          HTMLText = htmlcode;
          Thread m_thread = new Thread(new ThreadStart(generateText));
          m_thread.SetApartmentState(ApartmentState.STA);
          m_thread.Start();
          m_thread.Join();
          return PlainText;
      }

      private void generateText()
      {
          WebBrowser m_WebBrowser = new WebBrowser();

          m_WebBrowser.ScrollBarsEnabled = false;
          m_WebBrowser.DocumentText = HTMLText;
          m_WebBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);
          m_WebBrowser.Dispose();
      }

      private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
      {
          WebBrowser m_WebBrowser = (WebBrowser)sender;
          Regex r = new Regex(@"\s+");
          PlainText =  r.Replace(m_WebBrowser.Document.Body.InnerText, @" ");
      }
  }
}
