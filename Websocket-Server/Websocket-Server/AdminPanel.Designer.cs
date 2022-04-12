
namespace Websocket_Server
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxChatRoomsListBox = new System.Windows.Forms.ListBox();
            this.uxConnectedUsersListBox = new System.Windows.Forms.ListBox();
            this.uxRegisterUsersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxChatRoomsListBox
            // 
            this.uxChatRoomsListBox.FormattingEnabled = true;
            this.uxChatRoomsListBox.Location = new System.Drawing.Point(302, 12);
            this.uxChatRoomsListBox.Name = "uxChatRoomsListBox";
            this.uxChatRoomsListBox.Size = new System.Drawing.Size(120, 95);
            this.uxChatRoomsListBox.TabIndex = 5;
            // 
            // uxConnectedUsersListBox
            // 
            this.uxConnectedUsersListBox.FormattingEnabled = true;
            this.uxConnectedUsersListBox.Location = new System.Drawing.Point(155, 12);
            this.uxConnectedUsersListBox.Name = "uxConnectedUsersListBox";
            this.uxConnectedUsersListBox.Size = new System.Drawing.Size(120, 95);
            this.uxConnectedUsersListBox.TabIndex = 4;
            // 
            // uxRegisterUsersListBox
            // 
            this.uxRegisterUsersListBox.FormattingEnabled = true;
            this.uxRegisterUsersListBox.Location = new System.Drawing.Point(4, 12);
            this.uxRegisterUsersListBox.Name = "uxRegisterUsersListBox";
            this.uxRegisterUsersListBox.Size = new System.Drawing.Size(120, 95);
            this.uxRegisterUsersListBox.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 152);
            this.Controls.Add(this.uxChatRoomsListBox);
            this.Controls.Add(this.uxConnectedUsersListBox);
            this.Controls.Add(this.uxRegisterUsersListBox);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxChatRoomsListBox;
        private System.Windows.Forms.ListBox uxConnectedUsersListBox;
        private System.Windows.Forms.ListBox uxRegisterUsersListBox;
    }
}