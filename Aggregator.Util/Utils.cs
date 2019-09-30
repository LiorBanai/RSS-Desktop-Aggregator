using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Aggregator.Util
{
    public class Utils
    {
        public static string FormatKBytes(ulong kbytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB" };
            ulong max = (ulong)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (kbytes > max)
                    return String.Format("{0:##.###} {1}", Decimal.Divide(kbytes, max), order);

                max /= scale;
            }
            return "0 KB";
        }
   
        public static void SerializeToBinaryFile<T>(T item, string filename, bool suppressError = false)
        {
            BinaryFormatter myformatter = new BinaryFormatter();
            string dirpath = Path.GetDirectoryName(filename);

            try
            {
                if (dirpath != null && !(Directory.Exists(dirpath)))
                    Directory.CreateDirectory(dirpath);
                using (Stream myWriter = File.Open(filename, FileMode.Create, FileAccess.ReadWrite))
                {

                    myformatter.Serialize(myWriter, item);
                }
            }
            catch (SerializationException ex)
            {
                MessageShow.ShowException("SerializeBinaryFile", ex, suppressError);
            }
        }

        public static T DeSerializeBinaryFile<T>(string filename, bool suppressError = false) where T : new()
        {
            BinaryFormatter myformatter = new BinaryFormatter();

            if (File.Exists(filename))
                try
                {
                    using (Stream myReader = File.Open(filename, FileMode.Open, FileAccess.Read))
                    {
                        return (T) myformatter.Deserialize(myReader, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageShow.ShowException("DeSerializeBinaryFile", ex, suppressError);
                    return new T();

                }
            return new T(); 
        }

        /// <summary>
        /// method for validating a url with regular expressions
        /// </summary>
        /// <param name="url">url we're validating</param>
        /// <returns>true if valid, otherwise false</returns>
        public static bool IsValidUrl(string url)
        {
            string pattern = @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(url);
        }

        /// <summary>
        /// this method update a given control with a given text
        /// since the call can initiated by different thread than the GUI Thread 
        /// we need to check if Invocation is need on the GUI thread 
        /// </summary>
        /// <param name="cnt">a given control for update</param>
        /// <param name="text">the text to set the label Text property</param>
        public static void UpdateControl(Control cnt, string text)
        {
            if (cnt.InvokeRequired)
            {
                cnt.BeginInvoke(new MethodInvoker(() => UpdateControl(cnt, text)));
            }
            else
                cnt.Text = text;
        }

        ///// <summary>
        ///// method for taking a screenshot from your WebBrowser control
        ///// </summary>
        ///// <param name="wb">the control we're working with</param>
        ///// <param name="width">width of the screenshot</param>
        ///// <param name="height">height of the screenshot</param>
        ///// <param name="imgName">name to save as</param>
        ///// <returns></returns>
        //public bool takeSnapshot(WebBrowser wb, ref int width, ref int height, ref string imgName)
        //{
        //    try
        //    {
        //        //create new Bitmap with the requested dimensions
        //        Bitmap bmp = new Bitmap(width, height);

        //        //create a new regtangle
        //        Rectangle rec = new Rectangle(0, 0, width, height);

        //        //grab the screenshot
        //        wb.DrawToBitmap(bmp, rec);

        //        //image from the Bitmap
        //        Image original = bmp;

        //        //Graphics object for formatting the image
        //        Graphics gfx = Graphics.FromImage(original);
        //        gfx.CompositingQuality = CompositingQuality.HighQuality;
        //        gfx.SmoothingMode = SmoothingMode.HighQuality;
        //        gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

        //        //draw the image
        //        gfx.DrawImage(original, rec);

        //        //save as PNG
        //        //NOTE: Can change this to the desired format
        //        original.Save(imgName, ImageFormat.Png);

        //        //close and clean-up
        //        gfx.Dispose();
        //        bmp.Dispose();
        //        original.Dispose();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Snapshot Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}




    }
}
