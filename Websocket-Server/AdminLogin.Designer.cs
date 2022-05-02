
namespace Websocket_Server
{
    partial class AdminLogin
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
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordLabel.Location = new System.Drawing.Point(9, 100);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxPasswordLabel.Size = new System.Drawing.Size(83, 18);
            this.uxPasswordLabel.TabIndex = 23;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameLabel.Location = new System.Drawing.Point(12, 9);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(91, 20);
            this.uxUsernameLabel.TabIndex = 22;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(13, 121);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.Size = new System.Drawing.Size(180, 20);
            this.uxPasswordTextBox.TabIndex = 21;
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.Location = new System.Drawing.Point(12, 35);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.Size = new System.Drawing.Size(181, 20);
            this.uxUsernameTextBox.TabIndex = 20;
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(118, 188);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(75, 34);
            this.uxCancelButton.TabIndex = 19;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoginButton.Location = new System.Drawing.Point(12, 188);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(75, 34);
            this.uxLoginButton.TabIndex = 18;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 234);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameLabel);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxLoginButton);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.TextBox uxPasswordTextBox;
        private System.Windows.Forms.TextBox uxUsernameTextBox;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Button uxLoginButton;
    }
}