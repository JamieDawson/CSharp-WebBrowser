using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_WebBrowserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Type out website URL and click button. Website will appear in WebBrowser.
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        //Updates the URL that you are on.
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
        //Sends you to previous page.
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        //Refreshes page.
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        //Moves you forward on page.
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        //Sends you to your homepage.
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
