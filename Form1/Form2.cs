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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hienthi_Click(object sender, EventArgs e)
        {
               
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listimage_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienthi.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                if (hienthi.Image != null)
                {
                    hienthi.Image.Dispose();
                }
                hienthi.Image = Image.FromFile(listimage.SelectedItem.ToString());

            }
            catch (Exception tb)
            {
                MessageBox.Show(tb.Message);
                return;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog chon = new FolderBrowserDialog();
            if (chon.ShowDialog() == DialogResult.OK)
            {
                duongdan.Text = chon.SelectedPath;
            }
            listimage.Items.Clear();
            try
            {
                foreach (string dsfile in Directory.GetFiles(chon.SelectedPath))
                {
                    FileInfo fi = new FileInfo(dsfile);
                    if (fi.Extension.Equals(".png") || fi.Extension.Equals(".jpg") || fi.Extension.Equals(".jpeg") || fi.Extension.Equals(".bmp"))
                    {
                        listimage.Items.Add(dsfile);
                    }
                }
            } 
            catch (Exception ex1)
                {
                MessageBox.Show(ex1.Message);
                return;
                }
           if (listimage.Items.Count >= 1)
            {
                listimage.SelectedIndex = 0;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listimage.SelectedIndex == 0)
            {
                listimage.SelectedIndex = listimage.Items.Count - 1;
            }
            else
            {
                listimage.SelectedIndex = listimage.SelectedIndex - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listimage.SelectedIndex >= listimage.Items.Count - 1)
            {
                listimage.SelectedIndex = 0;
            }
            else
            {
                listimage.SelectedIndex = listimage.SelectedIndex + 1;
            }

        }
    }
}
