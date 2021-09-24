namespace BasicFacebookFeatures
{
    public partial class ConfirmPosting
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.styledButton_Confirm = new BasicFacebookFeatures.StyledButton();
            this.styledButton_Undo = new BasicFacebookFeatures.StyledButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 26);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Post: ";
            // 
            // styledButton_Confirm
            // 
            this.styledButton_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styledButton_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButton_Confirm.HoverColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Location = new System.Drawing.Point(426, 136);
            this.styledButton_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styledButton_Confirm.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Confirm.Name = "styledButton_Confirm";
            this.styledButton_Confirm.Size = new System.Drawing.Size(110, 52);
            this.styledButton_Confirm.TabIndex = 10;
            this.styledButton_Confirm.Text = "Confirm";
            this.styledButton_Confirm.UseVisualStyleBackColor = false;
            this.styledButton_Confirm.Click += new System.EventHandler(this.styledButton_Confirm_Click);
            // 
            // styledButton_Undo
            // 
            this.styledButton_Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.styledButton_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.styledButton_Undo.HoverColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Undo.Location = new System.Drawing.Point(310, 136);
            this.styledButton_Undo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.styledButton_Undo.MouseClickColor = System.Drawing.Color.DarkSalmon;
            this.styledButton_Undo.Name = "styledButton_Undo";
            this.styledButton_Undo.Size = new System.Drawing.Size(110, 52);
            this.styledButton_Undo.TabIndex = 10;
            this.styledButton_Undo.Text = "Undo";
            this.styledButton_Undo.UseVisualStyleBackColor = false;
            this.styledButton_Undo.Click += new System.EventHandler(this.styledButton_Undo_Click);
            // 
            // ConfirmPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(545, 201);
            this.Controls.Add(this.styledButton_Undo);
            this.Controls.Add(this.styledButton_Confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfirmPosting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Posting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private StyledButton styledButton_Confirm;
        private StyledButton styledButton_Undo;
    }
}