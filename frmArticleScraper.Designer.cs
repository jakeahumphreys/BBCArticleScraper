namespace BBCArticleScraper
{
    partial class frmArticleScraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticleScraper));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArticleUrl = new System.Windows.Forms.TextBox();
            this.btnFetchArticle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArticleUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Article URL";
            // 
            // txtArticleUrl
            // 
            this.txtArticleUrl.Location = new System.Drawing.Point(6, 20);
            this.txtArticleUrl.Name = "txtArticleUrl";
            this.txtArticleUrl.Size = new System.Drawing.Size(446, 20);
            this.txtArticleUrl.TabIndex = 0;
            // 
            // btnFetchArticle
            // 
            this.btnFetchArticle.Location = new System.Drawing.Point(12, 70);
            this.btnFetchArticle.Name = "btnFetchArticle";
            this.btnFetchArticle.Size = new System.Drawing.Size(458, 23);
            this.btnFetchArticle.TabIndex = 1;
            this.btnFetchArticle.Text = "Fetch Article";
            this.btnFetchArticle.UseVisualStyleBackColor = true;
            this.btnFetchArticle.Click += new System.EventHandler(this.btnFetchArticle_Click);
            // 
            // frmArticleScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 106);
            this.Controls.Add(this.btnFetchArticle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticleScraper";
            this.Text = "BBC News Grabber";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArticleUrl;
        private System.Windows.Forms.Button btnFetchArticle;
    }
}

