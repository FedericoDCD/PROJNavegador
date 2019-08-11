namespace ProjBuscador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BttnClose = new System.Windows.Forms.Button();
            this.TxtUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.BttnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.PnlHist = new System.Windows.Forms.Panel();
            this.DTHist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.PnlHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTHist)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnClose
            // 
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Location = new System.Drawing.Point(749, -2);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(76, 45);
            this.BttnClose.TabIndex = 0;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = true;
            this.BttnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtUrl
            // 
            this.TxtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUrl.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUrl.HintText = "";
            this.TxtUrl.isPassword = false;
            this.TxtUrl.LineFocusedColor = System.Drawing.Color.Crimson;
            this.TxtUrl.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUrl.LineMouseHoverColor = System.Drawing.Color.Crimson;
            this.TxtUrl.LineThickness = 3;
            this.TxtUrl.Location = new System.Drawing.Point(13, 46);
            this.TxtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(611, 44);
            this.TxtUrl.TabIndex = 2;
            this.TxtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUrl_KeyPress);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(12, 97);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(800, 340);
            this.WebBrowser.TabIndex = 3;
            this.WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            this.WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser_Navigated);
            // 
            // BttnBack
            // 
            this.BttnBack.Location = new System.Drawing.Point(664, 56);
            this.BttnBack.Name = "BttnBack";
            this.BttnBack.Size = new System.Drawing.Size(32, 34);
            this.BttnBack.TabIndex = 4;
            this.BttnBack.Text = "←";
            this.BttnBack.UseVisualStyleBackColor = true;
            this.BttnBack.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(740, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "↻";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAVEGADOR WEB";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "🔎";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // PnlHist
            // 
            this.PnlHist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlHist.Controls.Add(this.DTHist);
            this.PnlHist.Controls.Add(this.button1);
            this.PnlHist.Controls.Add(this.label2);
            this.PnlHist.Location = new System.Drawing.Point(295, 133);
            this.PnlHist.Name = "PnlHist";
            this.PnlHist.Size = new System.Drawing.Size(263, 287);
            this.PnlHist.TabIndex = 9;
            this.PnlHist.Visible = false;
            // 
            // DTHist
            // 
            this.DTHist.AllowUserToAddRows = false;
            this.DTHist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DTHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTHist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DTHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTHist.DoubleBuffered = true;
            this.DTHist.EnableHeadersVisualStyles = false;
            this.DTHist.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DTHist.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DTHist.Location = new System.Drawing.Point(12, 68);
            this.DTHist.Name = "DTHist";
            this.DTHist.ReadOnly = true;
            this.DTHist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTHist.Size = new System.Drawing.Size(240, 202);
            this.DTHist.TabIndex = 11;
            this.DTHist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTHist_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(223, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "HISTORIAL";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(780, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "H";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PnlHist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BttnBack);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.BttnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlHist.ResumeLayout(false);
            this.PnlHist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUrl;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Button BttnBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel PnlHist;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DTHist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}

