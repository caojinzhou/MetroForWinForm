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

        public MainForm()
        {
            InitializeComponent();
            metroStyleManager.Theme = MetroThemeStyle.Default;
            metroStyleManager.Style = MetroColorStyle.Teal;


            mapBox1.Refresh();

            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/SZ_DISTR/SZ_DISTR.shp", true);

            SharpMap.Layers.VectorLayer vlay1 = new SharpMap.Layers.VectorLayer("States");
            vlay1.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/roadway/城市次干道.shp", true);

            SharpMap.Layers.VectorLayer vlay2 = new SharpMap.Layers.VectorLayer("States");
            vlay1.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/roadway/高速.shp", true);

            //构造土地样式
            VectorStyle style1 = new VectorStyle();
            style1.Fill = new SolidBrush(Color.FromArgb(232, 232, 232));

            VectorStyle style2 = new VectorStyle();
            style2.Fill = new SolidBrush(Color.FromArgb(255, 128, 0));

            VectorStyle style3 = new VectorStyle();
            style3.Fill = new SolidBrush(Color.FromArgb(204, 89, 68));

            VectorStyle style4 = new VectorStyle();
            style4.Fill = new SolidBrush(Color.FromArgb(86, 58, 255));


            ////
            //VectorStyle style1 = new VectorStyle();
            //style1.Fill = new SolidBrush(Color.FromArgb(204, 89, 68));
            //style1.EnableOutline = true;
            //style1.Outline = new Pen(Brushes.Black, 1.2f);
            //VectorStyle style2 = new VectorStyle();
            //style2.Fill = new SolidBrush(Color.FromArgb(253, 174, 97));
            //style2.EnableOutline = true;
            //style2.Outline = new Pen(Brushes.Black, 1.2f);
            //VectorStyle style3 = new VectorStyle();
            //style3.Fill = new SolidBrush(Color.FromArgb(255, 255, 192));
            //style3.EnableOutline = true;
            //style3.Outline = new Pen(Brushes.Black, 1.2f);
            //VectorStyle style4 = new VectorStyle();
            //style4.Fill = new SolidBrush(Color.FromArgb(166, 217, 106));
            //style4.EnableOutline = true;
            //style4.Outline = new Pen(Brushes.Black, 1.2f);
            //Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            //styles.Add("1", style1);
            //styles.Add("2", style2);
            //styles.Add("3", style3);
            //styles.Add("4", style4);
            //vlay.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("id", styles, style1);
            /////

            //创建地图
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            styles.Add("罗湖区", style1);
            styles.Add("福田区", style2);
            styles.Add("盐田区", style3);
            styles.Add("龙岗区", style4);
            styles.Add("宝安区", style4);
            styles.Add("坪山新区", style2);
            styles.Add("南山区", style4);

            //分配主题
            vlay.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("DISTRICT", styles, style1);
            //mapBox1.Map.Layers.Add(vlay2);
            mapBox1.Map.Layers.Add(vlay);
           // mapBox1.Map.Layers.Add(vlay1);

            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;

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
