
namespace BasicFacebookFeatures
{
    partial class FormLogin
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
            this.lableWelcome = new System.Windows.Forms.Label();
            this.buttonLogin = new StyledButton();
            this.SuspendLayout();
            // 
            // lableWelcome
            // 
            this.lableWelcome.AutoSize = true;
            this.lableWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lableWelcome.Font = new System.Drawing.Font("Papyrus", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableWelcome.Location = new System.Drawing.Point(56, 62);
            this.lableWelcome.Name = "lableWelcome";
            this.lableWelcome.Size = new System.Drawing.Size(673, 94);
            this.lableWelcome.TabIndex = 1;
            this.lableWelcome.Text = "Welcome To Facebook";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.BZBackColor = System.Drawing.Color.Teal;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLogin.DisplayText = "_";
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.Location = new System.Drawing.Point(72, 284);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonLogin.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonLogin.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLogin.Size = new System.Drawing.Size(189, 72);

            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 430);
            this.Controls.Add(this.lableWelcome);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(897, 486);
            this.Name = "FormLogin";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lableWelcome;
        private StyledButton buttonLogin;
    }
}