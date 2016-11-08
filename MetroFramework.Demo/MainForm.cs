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
            map1.AddMapbox(mapBoxTra);
            



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            basemapcheckbox.CheckState = CheckState.Checked;
            basemapcheckbox.Enabled = false;
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
                trainputtext.Text = lj;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lj = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lj = fbd.SelectedPath;
                traoutputtext.Text = lj;
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

        private void trainputbt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "文本文件(*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                 trainputtext.Text = opf.FileName;
            }
        }

        private void traoutputbt_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                traoutputtext.Text = fbd.SelectedPath;
            }
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            string str = @"../../../map/roadway/城市次干道.shp";
            SharpMap.Layers.VectorLayer road = new SharpMap.Layers.VectorLayer("road1");
           
            if (metroCheckBox5.CheckState == CheckState.Checked)
            {
                map1.AddLayer(str,road);
            }
            if (metroCheckBox5.CheckState==CheckState.Unchecked)           
            {
                mapBoxTra.Map.Layers.RemoveAt(1);
                mapBoxTra.Refresh();
            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string layerpath = "";
            OpenFileDialog opflayer = new OpenFileDialog();
            opflayer.InitialDirectory = "C:\\";
            opflayer.Filter = "文件(*.shp)|*.shp";
            if (opflayer.ShowDialog() == DialogResult.OK)
            {
                layerpath = opflayer.FileName;
            }
            SharpMap.Layers.VectorLayer newlayer1 = new SharpMap.Layers.VectorLayer("newlayer1");
            map1.AddLayer(layerpath,newlayer1);
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            string str = @"../../../map/roadway/高速.shp";
            SharpMap.Layers.VectorLayer gs = new SharpMap.Layers.VectorLayer("road1");
            if (metroCheckBox6.CheckState == CheckState.Checked)
            {
                map1.AddLayer(str, gs);
            }
            if (metroCheckBox6.CheckState == CheckState.Unchecked)
            {
                mapBoxTra.Map.Layers.RemoveAt(2);
                mapBoxTra.Refresh();
            }

        }

        private void metroCheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            string str = @"../../../map/roadway/国道.shp";
            SharpMap.Layers.VectorLayer gd = new SharpMap.Layers.VectorLayer("road1");
           
            
            if (metroCheckBox16.CheckState == CheckState.Checked)
            {
                map1.AddLayer(str, gd);
            }
            if (metroCheckBox16.CheckState == CheckState.Unchecked)
            {
                mapBoxTra.Map.Layers.RemoveAt(3);
                mapBoxTra.Refresh();
            }
        }
    }
}
