using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using System.IO;

namespace enkelBrowser
{
    public partial class enkelBrowser : Form
    {
        public enkelBrowser()
        {
            InitializeComponent();
        }

        #region generic
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        // Navigate to page
        private void Navigate()
        {
            String url = textboxurl.Text;
            WebBrowser.Navigate(url);
        }

        // Method to inject Js
        private void InjectJavascript(string injectSomeJs= "")
        {
            if (injectSomeJs == "")
            {
                injectSomeJs = Console.Text;
            }

            if (WebBrowser.Url != null)
            {
                HtmlElement head = WebBrowser.Document.GetElementsByTagName("head")[0];
                HtmlElement script = WebBrowser.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)script.DomElement;
                element.text = injectSomeJs;
                head.AppendChild(script);
            }
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        // Freeball and typ stuff in wpf app console to inject in browser
        private void Console_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InjectJavascript();
            }
        }

        // Lazy inject. Inject Js from pseudoJs.txt 
        private void btn_read_file_Click(object sender, EventArgs e)
        {
            try
            {
                // Get path to pseudoJs.txt and stuff
                string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                filePath = Directory.GetParent(filePath).FullName;
                filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
                filePath += @"\enkelBrowser\Content\pseudoJs.txt";

                // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();

                    if (!String.IsNullOrEmpty(line))
                    {
                        InjectJavascript(line);
                    }
                }
            }
            catch (Exception ex)
            {
                var erroMsg = ex;
            }
        }
    }
}
