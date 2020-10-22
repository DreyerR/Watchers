using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchers.Forms
{
    class InputBox
    {
        public static DialogResult ShowInputBox(string title, string promptText, ref string value)
        {
            Form form = new Form(); // create a new instance of a form
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title; // sets the form caption equal to the string parameter
            label.Text = promptText; // sets the label text from the promptText parameter
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK; // if buttonOK is clicked, it returns a dialog result of OK
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 10, 372, 13); // Position the label on the form
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonOk.Size = new Size(75, 34);
            buttonCancel.SetBounds(309, 72, 75, 23);
            buttonCancel.Size = new Size(75, 34);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 125); // set the width and height of the form
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 13, FontStyle.Regular, GraphicsUnit.Pixel); // changes the form's font
            form.Font = font;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult; // return the result of which button was clicked
        }
    }
}
