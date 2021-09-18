namespace BasicFacebookFeatures
{
    partial class Font_Pick
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
            this.comboBox_FontStyle = new System.Windows.Forms.ComboBox();
            this.label_FontStyle = new System.Windows.Forms.Label();
            this.label_Font = new System.Windows.Forms.Label();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.label_Sample = new System.Windows.Forms.Label();
            this.styledButton_Confirm = new BasicFacebookFeatures.StyledButton();
            this.label_ShowText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(293, 53);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(121, 24);
            this.comboBox_FontStyle.TabIndex = 4;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontStyle_SelectedIndexChanged);
            // 
            // label_FontStyle
            // 
            this.label_FontStyle.AutoSize = true;
            this.label_FontStyle.Location = new System.Drawing.Point(290, 23);
            this.label_FontStyle.Name = "label_FontStyle";
            this.label_FontStyle.Size = new System.Drawing.Size(75, 17);
            this.label_FontStyle.TabIndex = 5;
            this.label_FontStyle.Text = "Font Style:";
            // 
            // label_Font
            // 
            this.label_Font.AutoSize = true;
            this.label_Font.Location = new System.Drawing.Point(12, 23);
            this.label_Font.Name = "label_Font";
            this.label_Font.Size = new System.Drawing.Size(40, 17);
            this.label_Font.TabIndex = 6;
            this.label_Font.Text = "Font:";
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.Location = new System.Drawing.Point(15, 53);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(227, 24);
            this.comboBox_Font.TabIndex = 7;
            this.comboBox_Font.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // label_Sample
            // 
            this.label_Sample.AutoSize = true;
            this.label_Sample.Location = new System.Drawing.Point(29, 114);
            this.label_Sample.Name = "label_Sample";
            this.label_Sample.Size = new System.Drawing.Size(59, 17);
            this.label_Sample.TabIndex = 8;
            this.label_Sample.Text = "Sample:";
            // 
            // styledButton_Confirm
            // 
            this.styledButton_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styledButton_Confirm.BackColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.BZBackColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButton_Confirm.Location = new System.Drawing.Point(360, 150);
            this.styledButton_Confirm.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.MouseHoverColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Name = "styledButton_Confirm";
            this.styledButton_Confirm.Size = new System.Drawing.Size(98, 42);
            this.styledButton_Confirm.TabIndex = 10;
            this.styledButton_Confirm.Text = "Confirm";
            this.styledButton_Confirm.UseVisualStyleBackColor = false;
            this.styledButton_Confirm.Click += new System.EventHandler(this.styledButton_Confirm_Click);
            // 
            // label_ShowText
            // 
            this.label_ShowText.AutoSize = true;
            this.label_ShowText.BackColor = System.Drawing.Color.Transparent;
            this.label_ShowText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ShowText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_ShowText.Font = new System.Drawing.Font("Papyrus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowText.ForeColor = System.Drawing.Color.Black;
            this.label_ShowText.Location = new System.Drawing.Point(94, 97);
            this.label_ShowText.Name = "label_ShowText";
            this.label_ShowText.Size = new System.Drawing.Size(197, 62);
            this.label_ShowText.TabIndex = 11;
            this.label_ShowText.Text = "Facybook";
            // 
            // Font_Pick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(470, 204);
            this.Controls.Add(this.label_ShowText);
            this.Controls.Add(this.styledButton_Confirm);
            this.Controls.Add(this.label_Sample);
            this.Controls.Add(this.comboBox_Font);
            this.Controls.Add(this.label_Font);
            this.Controls.Add(this.label_FontStyle);
            this.Controls.Add(this.comboBox_FontStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Font_Pick";
            this.Text = "Font_Pick";
            this.Load += new System.EventHandler(this.Font_Pick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_FontStyle;
        private System.Windows.Forms.Label label_FontStyle;
        private System.Windows.Forms.Label label_Font;
        private System.Windows.Forms.ComboBox comboBox_Font;
        private System.Windows.Forms.Label label_Sample;
        private StyledButton styledButton_Confirm;
        private System.Windows.Forms.Label label_ShowText;
    }
}