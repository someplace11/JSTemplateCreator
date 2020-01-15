using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JSConsoleTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates HTML Template File w/ button and linked 'test' script
                StreamWriter templateFile;

                templateFile = File.CreateText("index.html");

                string templateCode =
                    "<!DOCTYPE html>\r\n" +
                    "<html lang='en'>\r\n" +
                    "<head>\r\n" +
                    "   <meta charset='UTF-8'>\r\n" +
                    "   <meta name='viewport' content='width=device-width, initial-scale=1.0'>\r\n" +
                    "   <meta http-equiv='X-UA-Compatible' content='ie=edge'>\r\n" +
                    "   <title>Document</title>\r\n" +
                    "</head>\r\n" +
                    "<body>\r\n" +
                    "   <h1>Make sure console is open</h1>\r\n" +
                    "   <button onClick='showInConsole()'>Click Here</button>\r\n" +
                    "   <script src='test.js'></script>\r\n" +
                    "</body>\r\n" +
                    "</html>";

                templateFile.WriteLine(templateCode);

                templateFile.Close();

                // Creates JS File with linked function and script name
                StreamWriter scriptFile;

                scriptFile = File.CreateText("test.js");

                string scriptCode =
                    "function showInConsole() {\r\n" +
                    "   console.log('Test');\r\n" +
                    "}";

                scriptFile.WriteLine(scriptCode);

                scriptFile.Close();

                System.Diagnostics.Process.Start("index.html");
                System.Diagnostics.Process.Start("test.js");

                Application.Exit();
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message);
            }
        }
    }
}
