using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_Library;
using Websocket_Client;

namespace Websocket_Client_Chat
{
    public delegate bool Message(string message);
    public delegate List<User> GetAllUsersLogicDel();
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChatController controller = new ChatController();
            List<User> allUsers = new List<User>();

            ChatForm f = new ChatForm(controller.MessageEntered);
            LoginForm logInForm = new LoginForm(f);
            

            logInForm.SetUp(controller.CheckDatabase, controller.AddToContactListLogic, 
                controller.UpdateContactListLogic, controller.RemoveContactListLogic,controller.LogoutLogic, controller.setNameLogic);
            //Application.Run(logInForm);
            //uxCredentialsForm f =
            //string name = GetName();

            controller.MessageReceived += f.MessageReceived;

            Application.Run(logInForm);
            
        }

        // Ask for a name (that is a non-empty string)
        //private static string GetName()
        //{
        //    string name = "";
        //    do
        //    {
        //        while (InputBox("Name", "Enter user name:", ref name) != DialogResult.OK) ;
        //    }
        //    while (name == "");
        //    return name;
        //}

        //// From http://www.csharp-examples.net/inputbox/
        //public static DialogResult InputBox(string title, string promptText, ref string value)
        //{
        //    Form form = new Form();
        //    Label label = new Label();
        //    TextBox textBox = new TextBox();
        //    Button buttonOk = new Button();
        //    Button buttonCancel = new Button();

        //    form.Text = title;
        //    label.Text = promptText;
        //    textBox.Text = value;

        //    buttonOk.Text = "OK";
        //    buttonCancel.Text = "Cancel";
        //    buttonOk.DialogResult = DialogResult.OK;
        //    buttonCancel.DialogResult = DialogResult.Cancel;

        //    label.SetBounds(9, 20, 372, 13);
        //    textBox.SetBounds(12, 36, 372, 20);
        //    buttonOk.SetBounds(228, 72, 75, 23);
        //    buttonCancel.SetBounds(309, 72, 75, 23);

        //    label.AutoSize = true;
        //    textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        //    buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        //    buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        //    form.ClientSize = new Size(396, 107);
        //    form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
        //    form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        //    form.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    form.StartPosition = FormStartPosition.CenterScreen;
        //    form.MinimizeBox = false;
        //    form.MaximizeBox = false;
        //    form.AcceptButton = buttonOk;
        //    form.CancelButton = buttonCancel;

        //    DialogResult dialogResult = form.ShowDialog();
        //    value = textBox.Text;
        //    return dialogResult;
        //}
    }
}
