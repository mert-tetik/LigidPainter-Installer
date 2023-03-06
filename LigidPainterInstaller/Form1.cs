using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigidPainterInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //BlendTxtr.blendPictures(pictureBox1, pictureBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string exportPath = folderBrowserDialog1.SelectedPath;

            textBox1.Text = exportPath;
        }
    }
}
