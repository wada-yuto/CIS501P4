
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
            this.uxAllUsersListBox = new System.Windows.Forms.ListBox();
            this.uxOnlineUsersListBox = new System.Windows.Forms.ListBox();
            this.uxChatRoomListBoxs = new System.Windows.Forms.ListBox();
            this.uxAllUsersLabel = new System.Windows.Forms.Label();
            this.uxOnlineUsersLabel = new System.Windows.Forms.Label();
            this.uxChatRoomsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAllUsersListBox
            // 
            this.uxAllUsersListBox.FormattingEnabled = true;
            this.uxAllUsersListBox.Location = new System.Drawing.Point(12, 38);
            this.uxAllUsersListBox.Name = "uxAllUsersListBox";
            this.uxAllUsersListBox.Size = new System.Drawing.Size(164, 303);
            this.uxAllUsersListBox.TabIndex = 0;
            // 
            // uxOnlineUsersListBox
            // 
            this.uxOnlineUsersListBox.FormattingEnabled = true;
            this.uxOnlineUsersListBox.Location = new System.Drawing.Point(197, 38);
            this.uxOnlineUsersListBox.Name = "uxOnlineUsersListBox";
            this.uxOnlineUsersListBox.Size = new System.Drawing.Size(169, 303);
            this.uxOnlineUsersListBox.TabIndex = 1;
            // 
            // uxChatRoomListBoxs
            // 
            this.uxChatRoomListBoxs.FormattingEnabled = true;
            this.uxChatRoomListBoxs.Location = new System.Drawing.Point(386, 38);
            this.uxChatRoomListBoxs.Name = "uxChatRoomListBoxs";
            this.uxChatRoomListBoxs.Size = new System.Drawing.Size(169, 303);
            this.uxChatRoomListBoxs.TabIndex = 2;
            // 
            // uxAllUsersLabel
            // 
            this.uxAllUsersLabel.AutoSize = true;
            this.uxAllUsersLabel.Location = new System.Drawing.Point(57, 22);
            this.uxAllUsersLabel.Name = "uxAllUsersLabel";
            this.uxAllUsersLabel.Size = new System.Drawing.Size(48, 13);
            this.uxAllUsersLabel.TabIndex = 3;
            this.uxAllUsersLabel.Text = "All Users";
            // 
            // uxOnlineUsersLabel
            // 
            this.uxOnlineUsersLabel.AutoSize = true;
            this.uxOnlineUsersLabel.Location = new System.Drawing.Point(243, 22);
            this.uxOnlineUsersLabel.Name = "uxOnlineUsersLabel";
            this.uxOnlineUsersLabel.Size = new System.Drawing.Size(67, 13);
            this.uxOnlineUsersLabel.TabIndex = 4;
            this.uxOnlineUsersLabel.Text = "Online Users";
            // 
            // uxChatRoomsLabel
            // 
            this.uxChatRoomsLabel.AutoSize = true;
            this.uxChatRoomsLabel.Location = new System.Drawing.Point(425, 22);
            this.uxChatRoomsLabel.Name = "uxChatRoomsLabel";
            this.uxChatRoomsLabel.Size = new System.Drawing.Size(106, 13);
            this.uxChatRoomsLabel.TabIndex = 5;
            this.uxChatRoomsLabel.Text = "Chat Rooms Opened";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 353);
            this.Controls.Add(this.uxChatRoomsLabel);
            this.Controls.Add(this.uxOnlineUsersLabel);
            this.Controls.Add(this.uxAllUsersLabel);
            this.Controls.Add(this.uxChatRoomListBoxs);
            this.Controls.Add(this.uxOnlineUsersListBox);
            this.Controls.Add(this.uxAllUsersListBox);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxAllUsersListBox;
        private System.Windows.Forms.ListBox uxOnlineUsersListBox;
        private System.Windows.Forms.ListBox uxChatRoomListBoxs;
        private System.Windows.Forms.Label uxAllUsersLabel;
        private System.Windows.Forms.Label uxOnlineUsersLabel;
        private System.Windows.Forms.Label uxChatRoomsLabel;
    }
}