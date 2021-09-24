namespace BasicFacebookFeatures
{
    public partial class SuggetionPicker
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
            this.label_Suggestions = new System.Windows.Forms.Label();
            this.comboBox_Suggestions = new System.Windows.Forms.ComboBox();
            this.styledButton_Confirm = new BasicFacebookFeatures.StyledButton();
            this.styledButton_Confirm = new BasicFacebookFeatures.StyledButton();
            this.SuspendLayout();
            // 
            // label_Suggestions
            // 
            this.label_Suggestions.AutoSize = true;
            this.label_Suggestions.Location = new System.Drawing.Point(201, 36);
            this.label_Suggestions.Name = "label_Suggestions";
            this.label_Suggestions.Size = new System.Drawing.Size(102, 20);
            this.label_Suggestions.TabIndex = 6;
            this.label_Suggestions.Text = "Suggestions:";
            // 
            // comboBox_Suggestions
            // 
            this.comboBox_Suggestions.FormattingEnabled = true;
            this.comboBox_Suggestions.Location = new System.Drawing.Point(121, 74);
            this.comboBox_Suggestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Suggestions.Name = "comboBox_Suggestions";
            this.comboBox_Suggestions.Size = new System.Drawing.Size(255, 28);
            this.comboBox_Suggestions.TabIndex = 7;
            // 
            // styledButton_Confirm
            // 
            this.styledButton_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styledButton_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButton_Confirm.HoverColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Location = new System.Drawing.Point(385, 169);
            this.styledButton_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styledButton_Confirm.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Name = "styledButton_Confirm";
            this.styledButton_Confirm.Size = new System.Drawing.Size(110, 52);
            this.styledButton_Confirm.TabIndex = 10;
            this.styledButton_Confirm.Text = "Confirm";
            this.styledButton_Confirm.UseVisualStyleBackColor = false;
            this.styledButton_Confirm.Click += new System.EventHandler(this.styledButton_Confirm_Click);

            // 
            // SuggetionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(478, 210);
            this.Controls.Add(this.styledButton_Confirm);
            this.Controls.Add(this.comboBox_Suggestions);
            this.Controls.Add(this.label_Suggestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SuggetionPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font_Pick";
            this.Load += new System.EventHandler(this.SuggetionPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Suggestions;
        private System.Windows.Forms.ComboBox comboBox_Suggestions;
        private BasicFacebookFeatures.StyledButton styledButton_Confirm;
    }
}