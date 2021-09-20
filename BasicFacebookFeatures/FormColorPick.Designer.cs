
namespace BasicFacebookFeatures
{
    public partial class FormColorPick
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
            this.label_ChooseColor = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.label_Red = new System.Windows.Forms.Label();
            this.lable_Blue = new System.Windows.Forms.Label();
            this.label_Green = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmButton = new BasicFacebookFeatures.StyledButton();
            this.pictureBox_ShowColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ChooseColor
            // 
            this.label_ChooseColor.AutoSize = true;
            this.label_ChooseColor.Location = new System.Drawing.Point(127, 26);
            this.label_ChooseColor.Name = "label_ChooseColor";
            this.label_ChooseColor.Size = new System.Drawing.Size(109, 20);
            this.label_ChooseColor.TabIndex = 0;
            this.label_ChooseColor.Text = "Choose Color:";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(57, 65);
            this.numericUpDownRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownRed.TabIndex = 2;
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(184, 65);
            this.numericUpDownGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(62, 26);
            this.numericUpDownGreen.TabIndex = 3;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(306, 65);
            this.numericUpDownBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownBlue.TabIndex = 4;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label_Red
            // 
            this.label_Red.AutoSize = true;
            this.label_Red.Location = new System.Drawing.Point(11, 66);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(43, 20);
            this.label_Red.TabIndex = 5;
            this.label_Red.Text = "Red:";
            // 
            // lable_Blue
            // 
            this.lable_Blue.AutoSize = true;
            this.lable_Blue.Location = new System.Drawing.Point(255, 67);
            this.lable_Blue.Name = "lable_Blue";
            this.lable_Blue.Size = new System.Drawing.Size(45, 20);
            this.lable_Blue.TabIndex = 6;
            this.lable_Blue.Text = "Blue:";
            // 
            // label_Green
            // 
            this.label_Green.AutoSize = true;
            this.label_Green.BackColor = System.Drawing.Color.Transparent;
            this.label_Green.Location = new System.Drawing.Point(120, 67);
            this.label_Green.Name = "label_Green";
            this.label_Green.Size = new System.Drawing.Size(58, 20);
            this.label_Green.TabIndex = 7;
            this.label_Green.Text = "Green:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sample: ";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.confirmButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmButton.Location = new System.Drawing.Point(254, 154);
            this.confirmButton.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.confirmButton.HoverColor = System.Drawing.Color.DarkSalmon;
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(145, 49);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // pictureBox_ShowColor
            // 
            this.pictureBox_ShowColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_ShowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ShowColor.Location = new System.Drawing.Point(195, 111);
            this.pictureBox_ShowColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_ShowColor.Name = "pictureBox_ShowColor";
            this.pictureBox_ShowColor.Size = new System.Drawing.Size(36, 32);
            this.pictureBox_ShowColor.TabIndex = 8;
            this.pictureBox_ShowColor.TabStop = false;
            // 
            // FormColorPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(411, 215);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_ShowColor);
            this.Controls.Add(this.label_Green);
            this.Controls.Add(this.lable_Blue);
            this.Controls.Add(this.label_Red);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.label_ChooseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormColorPick";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Pick";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ChooseColor;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Label label_Red;
        private System.Windows.Forms.Label lable_Blue;
        private System.Windows.Forms.Label label_Green;
        private System.Windows.Forms.PictureBox pictureBox_ShowColor;
        private System.Windows.Forms.Label label2;
        private StyledButton confirmButton;
    }
}
