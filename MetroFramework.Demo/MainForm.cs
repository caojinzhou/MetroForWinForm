using System;
using System.Drawing;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using SharpMap;
using System.IO;
using System.Text;
using SharpMap.Styles;

namespace MetroFramework.Demo
{
    public partial class MainForm : MetroForm
    {
        MapGeneration map1 = new MapGeneration();

        public MainForm()
        {
            InitializeComponent();
            metroStyleManager.Theme = MetroThemeStyle.Default;
            metroStyleManager.Style = MetroColorStyle.Teal;
            map1.AddMapbox(mapBox1);
//            map1.AddLayer();

           

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void 窗体主题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {

        }


        private void metroButton14_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            int line = 0, num = 0;
            string zancun = "";
            FileStream fs = File.OpenRead("D:\\DAT\\原始数据.txt");
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > -1)
            {
                line++;
                zancun = zancun + sr.ReadLine() + "\r\n";
                if (line == 100)
                {
                    line = 0;
                    num++;
                    Directory.CreateDirectory("D:\\DAT\\处理结果");
                    FileStream fs1 = new FileStream( "D:\\DAT\\处理结果" + "\\JG" + num + ".TXT", FileMode.Create, FileAccess.Write);//创建写入文件 
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.WriteLine(zancun);//开始写入值
                    sw.Close();
                    zancun = "";
                }
            }
           // listBox1.Items.Add(time + "：原始数据切割成" + num + "个文件！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lj = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "文本文件(*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                lj = opf.FileName;
                textBox1.Text = lj;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lj = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lj = fbd.SelectedPath;
                textBox2.Text = lj;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "文本文件(*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                 textBox1.Text = opf.FileName;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
        //private void updateprogress() //labei3显示进度百分比
        //{
        //    //metroProgressBar3.PerformStep();
        //    //label2.Text = Math.Round(((double)(metroProgressBar3.Value - metroProgressBar3.Minimum) / 
        //    //    (double)(metroProgressBar3.Maximum - metroProgressBar3.Minimum)) * 100.0).ToString() + "%";

        //}
    }
}
