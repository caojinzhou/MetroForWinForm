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
        List<SharpMap.Layers.VectorLayer> userlayer = new List<SharpMap.Layers.VectorLayer>();
        List<MetroFramework.Controls.MetroCheckBox> trausercheckbox = new List<MetroFramework.Controls.MetroCheckBox>();

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
            tralayercb1.Visible = false;
            tralayercb2.Visible = false;
            tralayercb3.Visible = false;
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {

        }


        private void metroButton14_Click(object sender, EventArgs e)
        {
           
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



        private void tralayerResultcb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tralayercb1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (tralayercb1.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[0]);
            }
            if (tralayercb1.CheckState == CheckState.Unchecked)
            {

                map1.DeleteLayer(userlayer[0]);
            }
        }

        private void tralayercb2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (tralayercb2.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[1]);
            }
            if (tralayercb2.CheckState == CheckState.Unchecked)
            {
                map1.DeleteLayer(userlayer[1]);
            }
        }

        private void tralayercb3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (tralayercb3.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[2]);
            }
            if (tralayercb3.CheckState == CheckState.Unchecked)
            {
                map1.DeleteLayer(userlayer[2]);
            }
        }

        private void addlayerbt_Click(object sender, EventArgs e)
        {
            string layertext = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "图层文件(*.shp)|*.shp";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (tralayercb1.Visible==false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    tralayercb1.Visible = true;
                    tralayercb1.CheckState = CheckState.Checked;
                    tralayercb1.Text = layertext;
                    SharpMap.Layers.VectorLayer layer3 = new SharpMap.Layers.VectorLayer("userlayer1");
                    layer3.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true);
                    userlayer.Add(layer3);
                    foreach (var item in userlayer)
                    {
                         index = userlayer.IndexOf(layer3);
                    }
                    //int index = userlayer.IndexOf(layer3);
                    //int index1 = userlayer.FindIndex(1);
                    lacationchange(index, tralayercb1);

                    map1.AddLayer(layer3);                    
                    path = "";
                    goto noticet;
                }
                if (tralayercb2.Visible == false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    tralayercb2.Visible = true;
                    tralayercb2.CheckState = CheckState.Checked;
                    tralayercb2.Text = layertext;
                    SharpMap.Layers.VectorLayer layer4 = new SharpMap.Layers.VectorLayer("userlayer2");
                    layer4.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true);
                    map1.AddLayer(layer4);
                    userlayer.Add(layer4);

                    foreach (var item in userlayer)
                    {
                        index = userlayer.IndexOf(layer4);
                    }
                    lacationchange(index, tralayercb2);

                    path = "";
                    goto noticet;
                }
                if (tralayercb3.Visible == false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    //addusercheckbox("trauserlayercb3", layertext, 19, 191);
                    tralayercb3.Visible = true;
                    tralayercb3.CheckState = CheckState.Checked;
                    tralayercb3.Text = layertext;
                    SharpMap.Layers.VectorLayer layer5 = new SharpMap.Layers.VectorLayer("userlayer3");
                    layer5.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true); 
                    map1.AddLayer(layer5);
                    userlayer.Add(layer5);
                    foreach (var item in userlayer)
                    {
                        index = userlayer.IndexOf(layer5);
                    }
                    lacationchange(index, tralayercb3);
                    path = "";
                    goto noticet;
                }

                if (tralayercb3.Visible == true)
                {
                    MetroMessageBox.Show(this, "\n\r\n\r对不起，您最多只能添加三个图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            noticet: mapBoxTra.Refresh();


        }


        private void deletlayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                metroContextMenu1.Show(MousePosition.X, MousePosition.Y);
            }


        }

      
        private void tracancel_Click(object sender, EventArgs e)
        {

           
            
        }
        
        //添加CheckBox的函数//暂时没有用
        public void addusercheckbox( string cbname, string cbtext, int x,int y)
        {
            MetroFramework.Controls.MetroCheckBox c = new MetroFramework.Controls.MetroCheckBox();
            c.Location = new System.Drawing.Point(x,y);
            c.BringToFront();
            c.Name = cbname;
            c.Text = cbtext;
            c.Checked = true;
            this.tralayerbox.Controls.Add(c);          
        }
        //位置变换函数
        public void lacationchange(int layerindex, MetroFramework.Controls.MetroCheckBox cb )
        {
            if (layerindex == 0)
            {
                cb.Location = new System.Drawing.Point(19, 111);
            }
            if (layerindex == 1)
            {
                cb.Location = new System.Drawing.Point(19, 153);
            }
            if (layerindex == 2)
            {
                cb.Location = new System.Drawing.Point(19, 191);
            }
        }

        private void 删除该图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
