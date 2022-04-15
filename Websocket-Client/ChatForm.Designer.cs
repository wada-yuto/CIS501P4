
namespace Websocket_Client
{
    partial class ChatForm
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
            this.uxMessageListBox = new System.Windows.Forms.ListBox();
            this.uxMessageLabel = new System.Windows.Forms.Label();
            this.uxMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxMessageListBox
            // 
            this.uxMessageListBox.FormattingEnabled = true;
            this.uxMessageListBox.Location = new System.Drawing.Point(13, 13);
            this.uxMessageListBox.Name = "uxMessageListBox";
            this.uxMessageListBox.Size = new System.Drawing.Size(372, 134);
            this.uxMessageListBox.TabIndex = 0;
            // 
            // uxMessageLabel
            // 
            this.uxMessageLabel.AutoSize = true;
            this.uxMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMessageLabel.Location = new System.Drawing.Point(12, 163);
            this.uxMessageLabel.Name = "uxMessageLabel";
            this.uxMessageLabel.Size = new System.Drawing.Size(78, 20);
            this.uxMessageLabel.TabIndex = 1;
            this.uxMessageLabel.Text = "Message:";
            // 
            // uxMessageTextBox
            // 
            this.uxMessageTextBox.Location = new System.Drawing.Point(96, 162);
            this.uxMessageTextBox.Name = "uxMessageTextBox";
            this.uxMessageTextBox.Size = new System.Drawing.Size(289, 20);
            this.uxMessageTextBox.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 200);
            this.Controls.Add(this.uxMessageTextBox);
            this.Controls.Add(this.uxMessageLabel);
            this.Controls.Add(this.uxMessageListBox);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxMessageListBox;
        private System.Windows.Forms.Label uxMessageLabel;
        private System.Windows.Forms.TextBox uxMessageTextBox;
    }
}