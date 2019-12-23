namespace FontViewer
{
    partial class Form1
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
            this.lbFont = new System.Windows.Forms.ListBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbCountFonts = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelFont = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblInform = new System.Windows.Forms.Label();
            this.txtBoxBottom = new System.Windows.Forms.TextBox();
            this.lblRegular = new System.Windows.Forms.Label();
            this.lblBold = new System.Windows.Forms.Label();
            this.lblItalic = new System.Windows.Forms.Label();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFont.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFont.FormattingEnabled = true;
            this.lbFont.Location = new System.Drawing.Point(0, 0);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(200, 425);
            this.lbFont.TabIndex = 0;
            this.lbFont.SelectedIndexChanged += new System.EventHandler(this.lbFont_SelectedIndexChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbCountFonts);
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1114, 25);
            this.panelTop.TabIndex = 1;
            // 
            // lbCountFonts
            // 
            this.lbCountFonts.AutoSize = true;
            this.lbCountFonts.Location = new System.Drawing.Point(12, 5);
            this.lbCountFonts.Name = "lbCountFonts";
            this.lbCountFonts.Size = new System.Drawing.Size(35, 13);
            this.lbCountFonts.TabIndex = 1;
            this.lbCountFonts.Text = "label1";
            // 
            // lblTop
            // 
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1114, 25);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "label";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFont
            // 
            this.panelFont.Controls.Add(this.lbFont);
            this.panelFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFont.Location = new System.Drawing.Point(0, 25);
            this.panelFont.Name = "panelFont";
            this.panelFont.Size = new System.Drawing.Size(200, 425);
            this.panelFont.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblInform);
            this.panelBottom.Controls.Add(this.txtBoxBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 411);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(914, 39);
            this.panelBottom.TabIndex = 3;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Location = new System.Drawing.Point(3, 4);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(118, 13);
            this.lblInform.TabIndex = 10;
            this.lblInform.Text = "Enter any text you want";
            // 
            // txtBoxBottom
            // 
            this.txtBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxBottom.Location = new System.Drawing.Point(0, 19);
            this.txtBoxBottom.Name = "txtBoxBottom";
            this.txtBoxBottom.Size = new System.Drawing.Size(914, 20);
            this.txtBoxBottom.TabIndex = 9;
            this.txtBoxBottom.TextChanged += new System.EventHandler(this.txtBoxBottom_TextChanged);
            // 
            // lblRegular
            // 
            this.lblRegular.AutoSize = true;
            this.lblRegular.Location = new System.Drawing.Point(241, 73);
            this.lblRegular.Name = "lblRegular";
            this.lblRegular.Size = new System.Drawing.Size(0, 13);
            this.lblRegular.TabIndex = 4;
            // 
            // lblBold
            // 
            this.lblBold.AutoSize = true;
            this.lblBold.Location = new System.Drawing.Point(244, 165);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(0, 13);
            this.lblBold.TabIndex = 5;
            // 
            // lblItalic
            // 
            this.lblItalic.AutoSize = true;
            this.lblItalic.Location = new System.Drawing.Point(244, 257);
            this.lblItalic.Name = "lblItalic";
            this.lblItalic.Size = new System.Drawing.Size(0, 13);
            this.lblItalic.TabIndex = 6;
            // 
            // lblUnderline
            // 
            this.lblUnderline.AutoSize = true;
            this.lblUnderline.Location = new System.Drawing.Point(244, 349);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(0, 13);
            this.lblUnderline.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.lblUnderline);
            this.Controls.Add(this.lblItalic);
            this.Controls.Add(this.lblBold);
            this.Controls.Add(this.lblRegular);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelFont);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FontViewer";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFont.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFont;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFont;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblRegular;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.Label lblItalic;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.TextBox txtBoxBottom;
        private System.Windows.Forms.Label lbCountFonts;
        private System.Windows.Forms.Label lblInform;
    }
}

