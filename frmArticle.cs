using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBCArticleScraper
{
    public partial class frmArticle : Form
    {
        private Article article;
        public frmArticle(Article article)
        {
            if(article.URL != "")
            {
                this.article = article;
            }

            InitializeComponent();
        }

        private void frmArticle_Load(object sender, EventArgs e)
        {
            this.Text = this.Text += " " + article.URL;
            lblDatePosted.Text = article.DatePosted;
            lblTitle.Text = article.Title;
            rtbArticleText.Text = article.ArticleText;
        }

        private void lblTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(article.URL);
        }
    }
}
