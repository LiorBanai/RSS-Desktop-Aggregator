using System;
using System.Windows.Forms;

namespace Aggregator.Util
{
    /// <summary>
    /// This Class encapsulates the user display messages 
    /// </summary>
    public static class MessageShow
    {
        #region Data Members

        public class MessageArgs : EventArgs
        {
            public string Message { get; internal set; }
            public MessageArgs(string msg)
            {
                this.Message = msg;
            }

        }

        public delegate void EventHandler<in T>(object sender, T e) where T : EventArgs;
        public static event EventHandler<MessageArgs> OnExceptionLogin = delegate { };
        public static event EventHandler<MessageArgs> OnMessageDisplay = delegate { };

        #endregion

        /// <summary>
        /// Central point for display Exceptions messages for the user
        /// </summary>
        /// <param name="sender">The object that called this method</param>
        /// <param name="ex">the Raised exception</param>
        /// <param name="suppressErrorDisplay">Suppress error</param>
        /// <returns>User response</returns>
        public static DialogResult ShowException(Object sender, Exception ex, bool suppressErrorDisplay=false)
        {
            string msg = "Error: " + ex.Message;
            if (ex.InnerException != null)
                msg += "\nInner Exceptions:\n" + GetInnerExceptionMessages(ex);

            OnExceptionLogin(sender, new MessageArgs(msg));

            if (suppressErrorDisplay)
                return DialogResult.Ignore;
            else
                return MessageBox.Show(msg, "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1);

        }

        /// <summary>
        /// Central point for general purpose Messaging Mechanism for the user 
        /// </summary>
        /// <param name="sender">The object that called this method</param>
        /// <param name="text">The text to show in the MessageBox</param>
        /// <param name="title">The title of the MessageBox</param>
        /// <param name="buttonsType">The user buttons to display</param>
        /// <param name="icon">The icon buttons to display</param>
        /// <returns>User response</returns>
        public static DialogResult ShowMessage(Object sender, String text, String title, MessageBoxButtons buttonsType = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            OnMessageDisplay(sender, new MessageArgs(text));

            return MessageBox.Show(text,
                                    title,
                                    buttonsType,
                                    icon,
                                    MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Gets all inner exceptions messages.
        /// </summary>
        /// <param name="ex">The exception</param>
        /// <returns>Messages from all inner exceptions.</returns>
        public static string GetInnerExceptionMessages(Exception ex)
        {
            Exception inner = ex.InnerException;
            string messages = String.Empty;

            while (inner != null)
            {
                messages += inner.Message;

                if (!messages.EndsWith("."))
                {
                    messages += ".";
                }

                inner = inner.InnerException;
                if (inner != null)
                    messages += "\n";
            }

            return messages;
        }

        /// <summary>
        /// Gets all inner exceptions messages (recursive mode).
        /// </summary>
        /// <param name="ex">The exception</param>
        /// <returns>Messages from all inner exceptions.</returns>
        public static string GetInnerExceptionRecursive(Exception ex)
        {
            if (ex.InnerException != null)
            {
                return string.Format("{0} > {1} ", ex.InnerException.Message, GetInnerExceptionRecursive(ex.InnerException));
            }

            return string.Empty;
        }

    }
}


