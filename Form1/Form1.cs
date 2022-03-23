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

namespace Form1
{
    public partial class Form1 : Form
    {
        FileStream fs;
        byte[] fileContents;
        AsyncCallback callback;
        delegate void InfoMessageDel(String info); 
        public Form1()
        {
            InitializeComponent();
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.ShowDialog();
            callback = new AsyncCallback(fs_StateChanged);
            try
            {
                fs = new FileStream(openfileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            fs.Seek(0, SeekOrigin.Begin);
            fileContents = new byte[fs.Length];
            fs.BeginRead(fileContents, 0, (int)fs.Length, callback,null);
        }
        private void fs_StateChanged(IAsyncResult asyncResult)
        {
            if (asyncResult.IsCompleted)
            {
                string s = Encoding.UTF8.GetString(fileContents);
                InfoMessage(s);
                fs.Close();
            }
        }
        private void InfoMessage(string s)
        {
            if (this.tbResult.InvokeRequired)
            {
                InfoMessageDel msg = new InfoMessageDel(InfoMessage);
                this.Invoke(msg, new object[] { s });
            }
            else tbResult.Text = s;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                { 
                    FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFunct_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
