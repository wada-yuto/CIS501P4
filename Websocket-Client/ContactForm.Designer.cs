
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uxContactAddLabel = new System.Windows.Forms.Label();
            this.uxAddContactUsername = new System.Windows.Forms.TextBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxStart = new System.Windows.Forms.Button();
            this.uxStartChatting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 355);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Friend";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uxContactAddLabel
            // 
            this.uxContactAddLabel.AutoSize = true;
            this.uxContactAddLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxContactAddLabel.Location = new System.Drawing.Point(281, 122);
            this.uxContactAddLabel.Name = "uxContactAddLabel";
            this.uxContactAddLabel.Size = new System.Drawing.Size(258, 17);
            this.uxContactAddLabel.TabIndex = 2;
            this.uxContactAddLabel.Text = "Enter contact username you want to add";
            // 
            // uxAddContactUsername
            // 
            this.uxAddContactUsername.Location = new System.Drawing.Point(284, 142);
            this.uxAddContactUsername.Name = "uxAddContactUsername";
            this.uxAddContactUsername.Size = new System.Drawing.Size(251, 20);
            this.uxAddContactUsername.TabIndex = 3;
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(284, 168);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(255, 37);
            this.uxAdd.TabIndex = 4;
            this.uxAdd.Text = "Add Friend";
            this.uxAdd.UseVisualStyleBackColor = true;
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(57, 25);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(189, 21);
            this.uxLabel.TabIndex = 5;
            this.uxLabel.Text = "(Username)\'s Friends List";
            // 
            // uxStart
            // 
            this.uxStart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStart.Location = new System.Drawing.Point(284, 367);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(255, 37);
            this.uxStart.TabIndex = 6;
            this.uxStart.Text = "Start Chat";
            this.uxStart.UseVisualStyleBackColor = true;
            // 
            // uxStartChatting
            // 
            this.uxStartChatting.AutoSize = true;
            this.uxStartChatting.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartChatting.Location = new System.Drawing.Point(281, 347);
            this.uxStartChatting.Name = "uxStartChatting";
            this.uxStartChatting.Size = new System.Drawing.Size(212, 17);
            this.uxStartChatting.TabIndex = 7;
            this.uxStartChatting.Text = "Select User you want to chat with";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 424);
            this.Controls.Add(this.uxStartChatting);
            this.Controls.Add(this.uxStart);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxAddContactUsername);
            this.Controls.Add(this.uxContactAddLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label uxContactAddLabel;
        private System.Windows.Forms.TextBox uxAddContactUsername;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.Label uxStartChatting;
    }
}