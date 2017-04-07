namespace enkelBrowser
{
    partial class enkelBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enkelBrowser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.textboxurl = new System.Windows.Forms.TextBox();
            this.textUrl = new System.Windows.Forms.Label();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.btn_read_file = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_read_file);
            this.panel1.Controls.Add(this.btnNavigate);
            this.panel1.Controls.Add(this.textboxurl);
            this.panel1.Controls.Add(this.textUrl);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNavigate
            // 
            this.btnNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavigate.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigate.Location = new System.Drawing.Point(611, 16);
            this.btnNavigate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(55, 30);
            this.btnNavigate.TabIndex = 2;
            this.btnNavigate.Text = "GO";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // textboxurl
            // 
            this.textboxurl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxurl.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxurl.Location = new System.Drawing.Point(98, 16);
            this.textboxurl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textboxurl.Name = "textboxurl";
            this.textboxurl.Size = new System.Drawing.Size(489, 30);
            this.textboxurl.TabIndex = 1;
            // 
            // textUrl
            // 
            this.textUrl.AutoSize = true;
            this.textUrl.Location = new System.Drawing.Point(35, 21);
            this.textUrl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(43, 19);
            this.textUrl.TabIndex = 0;
            this.textUrl.Text = "URL:";
            // 
            // WebBrowser
            // 
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(-2, 76);
            this.WebBrowser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(33, 29);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(912, 339);
            this.WebBrowser.TabIndex = 1;
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.Location = new System.Drawing.Point(20, 424);
            this.Console.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(871, 139);
            this.Console.TabIndex = 2;
            this.Console.Text = "";
            this.Console.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Console_KeyUp);
            // 
            // btn_read_file
            // 
            this.btn_read_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_read_file.Location = new System.Drawing.Point(695, 16);
            this.btn_read_file.Name = "btn_read_file";
            this.btn_read_file.Size = new System.Drawing.Size(101, 30);
            this.btn_read_file.TabIndex = 3;
            this.btn_read_file.Text = "ReadFile";
            this.btn_read_file.UseVisualStyleBackColor = true;
            this.btn_read_file.Click += new System.EventHandler(this.btn_read_file_Click);
            // 
            // enkelBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 607);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "enkelBrowser";
            this.Text = "enkelBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.TextBox textboxurl;
        private System.Windows.Forms.Label textUrl;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Button btn_read_file;
    }
}

