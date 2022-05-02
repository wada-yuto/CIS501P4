
namespace Websocket_Client
{
    partial class ContactForm
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
            this.components = new System.ComponentModel.Container();
            this.uxFriendListListBox = new System.Windows.Forms.ListBox();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxRemoveFriendButton = new System.Windows.Forms.Button();
            this.uxContactAddLabel = new System.Windows.Forms.Label();
            this.uxAddContactUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddFriendButton = new System.Windows.Forms.Button();
            this.uxFriendListLabel = new System.Windows.Forms.Label();
            this.uxStartChatButton = new System.Windows.Forms.Button();
            this.uxStartChatting = new System.Windows.Forms.Label();
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uxLogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFriendListListBox
            // 
            this.uxFriendListListBox.FormattingEnabled = true;
            this.uxFriendListListBox.Location = new System.Drawing.Point(27, 49);
            this.uxFriendListListBox.Name = "uxFriendListListBox";
            this.uxFriendListListBox.Size = new System.Drawing.Size(251, 355);
            this.uxFriendListListBox.TabIndex = 0;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Chat_Library.User);
            // 
            // uxRemoveFriendButton
            // 
            this.uxRemoveFriendButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveFriendButton.Location = new System.Drawing.Point(284, 49);
            this.uxRemoveFriendButton.Name = "uxRemoveFriendButton";
            this.uxRemoveFriendButton.Size = new System.Drawing.Size(251, 37);
            this.uxRemoveFriendButton.TabIndex = 1;
            this.uxRemoveFriendButton.Text = "Remove Friend";
            this.uxRemoveFriendButton.UseVisualStyleBackColor = true;
            this.uxRemoveFriendButton.Click += new System.EventHandler(this.uxRemoveFriendButton_Click);
            // 
            // uxContactAddLabel
            // 
            this.uxContactAddLabel.AutoSize = true;
            this.uxContactAddLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxContactAddLabel.Location = new System.Drawing.Point(281, 164);
            this.uxContactAddLabel.Name = "uxContactAddLabel";
            this.uxContactAddLabel.Size = new System.Drawing.Size(258, 17);
            this.uxContactAddLabel.TabIndex = 2;
            this.uxContactAddLabel.Text = "Enter contact username you want to add";
            // 
            // uxAddContactUsernameTextBox
            // 
            this.uxAddContactUsernameTextBox.Location = new System.Drawing.Point(284, 184);
            this.uxAddContactUsernameTextBox.Name = "uxAddContactUsernameTextBox";
            this.uxAddContactUsernameTextBox.Size = new System.Drawing.Size(251, 20);
            this.uxAddContactUsernameTextBox.TabIndex = 3;
            // 
            // uxAddFriendButton
            // 
            this.uxAddFriendButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddFriendButton.Location = new System.Drawing.Point(284, 210);
            this.uxAddFriendButton.Name = "uxAddFriendButton";
            this.uxAddFriendButton.Size = new System.Drawing.Size(255, 37);
            this.uxAddFriendButton.TabIndex = 4;
            this.uxAddFriendButton.Text = "Add Friend";
            this.uxAddFriendButton.UseVisualStyleBackColor = true;
            this.uxAddFriendButton.Click += new System.EventHandler(this.uxAddFriendButton_Click);
            // 
            // uxFriendListLabel
            // 
            this.uxFriendListLabel.AutoSize = true;
            this.uxFriendListLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFriendListLabel.Location = new System.Drawing.Point(57, 25);
            this.uxFriendListLabel.Name = "uxFriendListLabel";
            this.uxFriendListLabel.Size = new System.Drawing.Size(189, 21);
            this.uxFriendListLabel.TabIndex = 5;
            this.uxFriendListLabel.Text = "(Username)\'s Friends List";
            // 
            // uxStartChatButton
            // 
            this.uxStartChatButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChatButton.Location = new System.Drawing.Point(284, 294);
            this.uxStartChatButton.Name = "uxStartChatButton";
            this.uxStartChatButton.Size = new System.Drawing.Size(255, 37);
            this.uxStartChatButton.TabIndex = 6;
            this.uxStartChatButton.Text = "Start Chat";
            this.uxStartChatButton.UseVisualStyleBackColor = true;
            this.uxStartChatButton.Click += new System.EventHandler(this.uxStartChatButton_Click);
            // 
            // uxStartChatting
            // 
            this.uxStartChatting.AutoSize = true;
            this.uxStartChatting.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChatting.Location = new System.Drawing.Point(284, 274);
            this.uxStartChatting.Name = "uxStartChatting";
            this.uxStartChatting.Size = new System.Drawing.Size(212, 17);
            this.uxStartChatting.TabIndex = 7;
            this.uxStartChatting.Text = "Select User you want to chat with";
            this.uxStartChatting.Click += new System.EventHandler(this.uxStartChatting_Click);
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataMember = "Contacts";
            this.contactsBindingSource1.DataSource = this.userBindingSource;
            // 
            // contactsBindingSource2
            // 
            this.contactsBindingSource2.DataMember = "Contacts";
            this.contactsBindingSource2.DataSource = this.userBindingSource;
            // 
            // uxLogoutButton
            // 
            this.uxLogoutButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.uxLogoutButton.Location = new System.Drawing.Point(284, 367);
            this.uxLogoutButton.Name = "uxLogoutButton";
            this.uxLogoutButton.Size = new System.Drawing.Size(255, 37);
            this.uxLogoutButton.TabIndex = 8;
            this.uxLogoutButton.Text = "Logout";
            this.uxLogoutButton.UseVisualStyleBackColor = true;
            this.uxLogoutButton.Click += new System.EventHandler(this.uxLogoutButton_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 424);
            this.Controls.Add(this.uxLogoutButton);
            this.Controls.Add(this.uxStartChatting);
            this.Controls.Add(this.uxStartChatButton);
            this.Controls.Add(this.uxFriendListLabel);
            this.Controls.Add(this.uxAddFriendButton);
            this.Controls.Add(this.uxAddContactUsernameTextBox);
            this.Controls.Add(this.uxContactAddLabel);
            this.Controls.Add(this.uxRemoveFriendButton);
            this.Controls.Add(this.uxFriendListListBox);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxFriendListListBox;
        private System.Windows.Forms.Button uxRemoveFriendButton;
        private System.Windows.Forms.Label uxContactAddLabel;
        private System.Windows.Forms.TextBox uxAddContactUsernameTextBox;
        private System.Windows.Forms.Button uxAddFriendButton;
        private System.Windows.Forms.Label uxFriendListLabel;
        private System.Windows.Forms.Button uxStartChatButton;
        private System.Windows.Forms.Label uxStartChatting;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource contactsBindingSource1;
        private System.Windows.Forms.BindingSource contactsBindingSource2;
        private System.Windows.Forms.Button uxLogoutButton;
    }
}