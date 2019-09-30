using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Aggregator.Util;

namespace Aggregator.Convert
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
                    return string.Format("{0:##.###} {1}", decimal.Divide(kbytes, max), order);

                max /= scale;
            }
            return "0 KB";
        }

        public static void SerializeToBinaryFile<T>(T items,string filename, bool suppressError = false)
        {
            BinaryFormatter myformatter = new BinaryFormatter();

            using (Stream myWriter = File.Open(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                try
                {
                    myformatter.Serialize(myWriter, items);
                }
                catch (SerializationException ex)
                {
                    MessageShow.ShowException("SerializeBinaryFile", ex, suppressError);
                }
            }
        }

        public static List<T> DeSerializeBinaryFile<T>(string filename, bool suppressError = false)
    {
        BinaryFormatter myformatter = new BinaryFormatter();

        if (File.Exists(filename))
            try
            {
                using (Stream myReader = File.Open(filename, FileMode.Open, FileAccess.Read))
                {
                    return (List<T>)myformatter.Deserialize(myReader, null);
                }
            }
            catch (Exception ex)
            {
                MessageShow.ShowException("DeSerializeBinaryFile", ex, suppressError);
                return new List<T>(0);

            }
        return new List<T>(0);
    }
        
    }
}
