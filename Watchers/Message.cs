using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers
{
    class Message
    {
        public enum MessageType { Information, Error, Warning };

        public static void ShowMessage(string message, MessageType type)
        {
            switch (type)
            {
                case MessageType.Error:
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageType.Information:
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            } 
        }
    }
}
