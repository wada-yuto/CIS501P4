
namespace Websocket_Client_Chat
{
    partial class uxCredentialsForm
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
            this.uxUsernameInput = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxPasswordInput = new System.Windows.Forms.TextBox();
            this.uxUsername = new System.Windows.Forms.Label();
            this.uxPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxUsernameInput
            // 
            this.uxUsernameInput.Location = new System.Drawing.Point(113, 47);
            this.uxUsernameInput.Name = "uxUsernameInput";
            this.uxUsernameInput.Size = new System.Drawing.Size(254, 20);
            this.uxUsernameInput.TabIndex = 0;
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(113, 121);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(254, 39);
            this.uxLogin.TabIndex = 1;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxPasswordInput
            // 
            this.uxPasswordInput.Location = new System.Drawing.Point(113, 83);
            this.uxPasswordInput.Name = "uxPasswordInput";
            this.uxPasswordInput.Size = new System.Drawing.Size(254, 20);
            this.uxPasswordInput.TabIndex = 2;
            // 
            // uxUsername
            // 
            this.uxUsername.AutoSize = true;
            this.uxUsername.Location = new System.Drawing.Point(41, 50);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(61, 13);
            this.uxUsername.TabIndex = 3;
            this.uxUsername.Text = "Username: ";
            // 
            // uxPassword
            // 
            this.uxPassword.AutoSize = true;
            this.uxPassword.Location = new System.Drawing.Point(43, 86);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(59, 13);
            this.uxPassword.TabIndex = 4;
            this.uxPassword.Text = "Password: ";
            // 
            // uxCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 172);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPasswordInput);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxUsernameInput);
            this.Name = "uxCredentialsForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.CredentialsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxUsernameInput;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.TextBox uxPasswordInput;
        private System.Windows.Forms.Label uxUsername;
        private System.Windows.Forms.Label uxPassword;
    }
}