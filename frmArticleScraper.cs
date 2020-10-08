using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace BBCArticleScraper
{
    public partial class frmArticleScraper : Form
    {
        public frmArticleScraper()
        {
            InitializeComponent();
        }

        private void btnFetchArticle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArticleUrl.Text != "")
                {
                    if (txtArticleUrl.Text.Contains("https://www.bbc.co.uk/news/"))
                    {
                        string htmlString = scrapeUrl(txtArticleUrl.Text);

                        if(htmlString != "")
                        {
                            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                            htmlDocument.LoadHtml(htmlString);

                            string articleTitle = "";
                            string datePosted = "";
                            string articleText = "";

                            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//h1[contains(@class, 'story-body__h1')]"))
                            {
                                articleTitle = node.InnerText;
                            }

                            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'date')]"))
                            {
                                datePosted = node.Attributes["data-datetime"].Value;
                            }

                            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'story-body__inner')]/p"))
                            {
                                articleText += node.InnerText + Environment.NewLine;
                            }

                            Article article = new Article { URL = txtArticleUrl.Text, ArticleText = articleText, DatePosted = datePosted, Title = articleTitle };

                            frmArticle articleForm = new frmArticle(article);

                            articleForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No valid data was returned, Please check the URL submitted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("URL is not a valid BBC news article.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a BBC news article URL to fetch.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Article data not found, please check the URL submitted.");
            }
        }

        private string scrapeUrl(string url)
        {
            try
            {
                if (url != "")
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    string urlSource = reader.ReadToEnd();
                    reader.Close();
                    response.Close();

                    return urlSource;
                }
                else
                {
                    MessageBox.Show("Please specify a URL to scrape.");
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

    }
}
