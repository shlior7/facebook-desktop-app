namespace BasicFacebookFeatures
{
    partial class FormFontPick
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
            this.comboBox_FontFamily = new System.Windows.Forms.ComboBox();
            this.label_Sample = new System.Windows.Forms.Label();
            this.styledButton_Confirm = new BasicFacebookFeatures.StyledButton(false);
            this.label_ShowText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(330, 66);
            this.comboBox_FontStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(136, 28);
            this.comboBox_FontStyle.TabIndex = 4;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontStyle_SelectedIndexChanged);
            // 
            // label_FontStyle
            // 
            this.label_FontStyle.AutoSize = true;
            this.label_FontStyle.Location = new System.Drawing.Point(326, 29);
            this.label_FontStyle.Name = "label_FontStyle";
            this.label_FontStyle.Size = new System.Drawing.Size(85, 20);
            this.label_FontStyle.TabIndex = 5;
            this.label_FontStyle.Text = "Font Style:";
            // 
            // label_Font
            // 
            this.label_Font.AutoSize = true;
            this.label_Font.Location = new System.Drawing.Point(14, 29);
            this.label_Font.Name = "label_Font";
            this.label_Font.Size = new System.Drawing.Size(46, 20);
            this.label_Font.TabIndex = 6;
            this.label_Font.Text = "Font:";
            // 
            // comboBox_FontFamily
            // 
            this.comboBox_FontFamily.FormattingEnabled = true;
            this.comboBox_FontFamily.Location = new System.Drawing.Point(17, 66);
            this.comboBox_FontFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_FontFamily.Name = "comboBox_FontFamily";
            this.comboBox_FontFamily.Size = new System.Drawing.Size(255, 28);
            this.comboBox_FontFamily.TabIndex = 7;
            this.comboBox_FontFamily.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // label_Sample
            // 
            this.label_Sample.AutoSize = true;
            this.label_Sample.Location = new System.Drawing.Point(33, 142);
            this.label_Sample.Name = "label_Sample";
            this.label_Sample.Size = new System.Drawing.Size(67, 20);
            this.label_Sample.TabIndex = 8;
            this.label_Sample.Text = "Sample:";
            // 
            // styledButton_Confirm
            // 
            this.styledButton_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styledButton_Confirm.BackColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.BackColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButton_Confirm.Location = new System.Drawing.Point(385, 169);
            this.styledButton_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styledButton_Confirm.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.HoverColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Name = "styledButton_Confirm";
            this.styledButton_Confirm.Size = new System.Drawing.Size(110, 52);
            this.styledButton_Confirm.TabIndex = 10;
            this.styledButton_Confirm.Text = "Confirm";
            this.styledButton_Confirm.UseVisualStyleBackColor = false;
            this.styledButton_Confirm.Click += new System.EventHandler(this.styledButton_Confirm_Click);
            // 
            // label_ShowText
            // 
            this.label_ShowText.AutoSize = true;
            this.label_ShowText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_ShowText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_ShowText.Font = new System.Drawing.Font("Papyrus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowText.ForeColor = System.Drawing.Color.Black;
            this.label_ShowText.Location = new System.Drawing.Point(106, 121);
            this.label_ShowText.Name = "label_ShowText";
            this.label_ShowText.Size = new System.Drawing.Size(275, 84);
            this.label_ShowText.TabIndex = 11;
            this.label_ShowText.Text = "Facybook";
            // 
            // FormFontPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(509, 236);
            this.Controls.Add(this.label_ShowText);
            this.Controls.Add(this.styledButton_Confirm);
            this.Controls.Add(this.label_Sample);
            this.Controls.Add(this.comboBox_FontFamily);
            this.Controls.Add(this.label_Font);
            this.Controls.Add(this.label_FontStyle);
            this.Controls.Add(this.comboBox_FontStyle);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFontPick";
            this.Text = "Font_Pick";
            this.Load += new System.EventHandler(this.Font_Pick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_FontStyle;
        private System.Windows.Forms.Label label_FontStyle;
        private System.Windows.Forms.Label label_Font;
        private System.Windows.Forms.ComboBox comboBox_FontFamily;
        private System.Windows.Forms.Label label_Sample;
        private StyledButton styledButton_Confirm;
        private System.Windows.Forms.Label label_ShowText;
    }
}