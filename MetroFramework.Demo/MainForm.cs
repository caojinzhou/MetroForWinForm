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
        //两个列表相对应索引值；
        List<SharpMap.Layers.VectorLayer> userlayer = new List<SharpMap.Layers.VectorLayer>();
        List<MetroFramework.Controls.MetroCheckBox> trausercheckbox = new List<MetroFramework.Controls.MetroCheckBox>();

        //删除图层使用；
        MetroFramework.Controls.MetroCheckBox cbnamezc;
        //判断用户添加图层是否重复
        List<string> userlyname = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            metroStyleManager.Theme = MetroThemeStyle.Default;
            metroStyleManager.Style = MetroColorStyle.Teal;
            map1.AddMapbox(tramap);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            tra_baselayer_cb.CheckState = CheckState.Checked;
            tra_baselayer_cb.Enabled = false;
            tra_userlayer_cb1.Visible = false;
            tra_userlayer_cb2.Visible = false;
            tra_userlayer_cb3.Visible = false;
            tra_addlayer_bt.Location = new System.Drawing.Point(9, 111);
        }

        private void tra_input_bt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "文本文件(*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                 tra_input_tb.Text = opf.FileName;
            }
        }

        private void tra_output_bt_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tra_output_tb.Text = fbd.SelectedPath;
            }
        }
        
        private void tra_userlayer_cb1_CheckedChanged(object sender, EventArgs e)
        {           
            if (tra_userlayer_cb1.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb1)]);
            }
            if (tra_userlayer_cb1.CheckState == CheckState.Unchecked)
            {
                map1.DeleteLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb1)]);
            }
        }

        private void traldeletlayer_MouseDown(object sender, EventArgs e)
        {
            metroContextMenu1.Show(MousePosition.X, MousePosition.Y);
        }

        private void tra_userlayer_cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (tra_userlayer_cb2.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb2)]);

            }
            if (tra_userlayer_cb2.CheckState == CheckState.Unchecked)
            {
                map1.DeleteLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb2)]);
            }
        }

        private void tra_userlayer_cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (tra_userlayer_cb3.CheckState == CheckState.Checked)
            {
                map1.AddLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb3)]);
            }
            if (tra_userlayer_cb3.CheckState == CheckState.Unchecked)
            {
                map1.DeleteLayer(userlayer[trausercheckbox.IndexOf(tra_userlayer_cb3)]);
            }
        }

        private void tra_addlayer_bt_Click(object sender, EventArgs e)
        {
            string layertext = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "C:\\";
            opf.Filter = "图层文件(*.shp)|*.shp";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (tra_userlayer_cb1.Visible==false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);

                    if (userlyname.Contains(layertext))
                    {
                        MetroMessageBox.Show(this, "\n\r\n\r对不起，您已经添加了“"+ layertext+"”图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        userlyname.Add(layertext);
                        tra_userlayer_cb1.Visible = true;
                        tra_userlayer_cb1.Text = layertext;
                        SharpMap.Layers.VectorLayer layer3 = new SharpMap.Layers.VectorLayer("userlayer1");
                        layer3.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true);
                        //在对应列表中添加CheckBox和layer对应
                        userlayer.Add(layer3);
                        trausercheckbox.Add(tra_userlayer_cb1);
                        index = userlayer.IndexOf(layer3);

                        lacationchange(index, tra_userlayer_cb1);
                        tra_userlayer_cb1.CheckState = CheckState.Checked;
                        path = "";
                        goto noticet;

                    }
                }
                if (tra_userlayer_cb2.Visible == false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);

                    if (userlyname.Contains(layertext))
                    {
                        MetroMessageBox.Show(this, "\n\r\n\r对不起，您已经添加了“" + layertext + "”图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        userlyname.Add(layertext);
                        tra_userlayer_cb2.Visible = true;
                        tra_userlayer_cb2.Text = layertext;
                        SharpMap.Layers.VectorLayer layer4 = new SharpMap.Layers.VectorLayer("userlayer2");
                        layer4.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true);

                        //在对应列表中添加CheckBox和layer对应
                        userlayer.Add(layer4);
                        trausercheckbox.Add(tra_userlayer_cb2);
                        //引用位置变化的函数
                        index = userlayer.IndexOf(layer4);
                        lacationchange(index, tra_userlayer_cb2);
                        tra_userlayer_cb2.CheckState = CheckState.Checked;
                        path = "";
                        goto noticet;
                    }
                }
                if (tra_userlayer_cb3.Visible == false)
                {
                    int index = 0;
                    string path = opf.FileName;
                    layertext = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);

                    if (userlyname.Contains(layertext))
                    {
                        MetroMessageBox.Show(this, "\n\r\n\r对不起，您已经添加了“" + layertext + "”图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        userlyname.Add(layertext);
                        tra_userlayer_cb3.Visible = true;

                        tra_userlayer_cb3.Text = layertext;
                        SharpMap.Layers.VectorLayer layer5 = new SharpMap.Layers.VectorLayer("userlayer3");
                        layer5.DataSource = new SharpMap.Data.Providers.ShapeFile(path, true);

                        //在对应列表中添加CheckBox和layer对应
                        userlayer.Add(layer5);
                        trausercheckbox.Add(tra_userlayer_cb3);
                        index = userlayer.IndexOf(layer5);
                        lacationchange(index, tra_userlayer_cb3);
                        tra_userlayer_cb3.CheckState = CheckState.Checked;
                        path = "";
                        goto noticet;
                    }
                }

                if (tra_userlayer_cb3.Visible == true)
                {
                    MetroMessageBox.Show(this, "\n\r\n\r对不起，您最多只能添加三个图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            noticet: tramap.Refresh();
        }

        private void deletlayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                metroContextMenu1.Show(MousePosition.X, MousePosition.Y);
            }
            MetroFramework.Controls.MetroCheckBox cb = (MetroFramework.Controls.MetroCheckBox)sender;
            cbnamezc = cb;
        }
        
     
        private void 删除该图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delet();
        }
        //删除图层函数；
        public void delet()
        {
            int index = trausercheckbox.IndexOf(cbnamezc);//根据右键传值找出对应的索引值；
            if (cbnamezc.CheckState == CheckState.Checked)
            {
                cbnamezc.CheckState = CheckState.Unchecked;
                userlayer.RemoveAt(index);
                trausercheckbox.RemoveAt(index);
                userlyname.RemoveAt(index);
                cbnamezc.Visible = false;
                goto gun;
            }
            if (cbnamezc.CheckState == CheckState.Unchecked)
            {
                userlayer.RemoveAt(index);
                trausercheckbox.RemoveAt(index);
                userlyname.RemoveAt(index);
                cbnamezc.Visible = false;
                goto gun;
            }
            gun: tramap.Refresh();
            int i = 0;
            foreach (var item in trausercheckbox)
            {
                lacationchange(i, item);
                i++;
            }
        }
        //添加CheckBox的函数//暂时没有用
        public void addusercheckbox(string cbname, string cbtext, int x, int y)
        {
            MetroFramework.Controls.MetroCheckBox c = new MetroFramework.Controls.MetroCheckBox();
            c.Location = new System.Drawing.Point(x, y);
            c.BringToFront();
            c.Name = cbname;
            c.Text = cbtext;
            c.Checked = true;
            this.tra_layer_gb.Controls.Add(c);
        }
        //位置变换函数
        public void lacationchange(int layerindex, MetroFramework.Controls.MetroCheckBox cb)
        {
            if (layerindex == 0)
            {
                cb.Location = new System.Drawing.Point(9, 111);
                tra_addlayer_bt.Location = new System.Drawing.Point(9, 153);
            }
            if (layerindex == 1)
            {
                cb.Location = new System.Drawing.Point(9, 153);
                tra_addlayer_bt.Location = new System.Drawing.Point(9, 191);
            }
            if (layerindex == 2)
            {
                cb.Location = new System.Drawing.Point(9, 191);
                tra_addlayer_bt.Location = new System.Drawing.Point(9, 229);
            }
        }

     
        private void tra_next_bt_Click(object sender, EventArgs e)
        {
            FormTabControl.SelectedIndex = 1;
        }

        private void tra_start_bt_Click(object sender, EventArgs e)
        {

        }

       
    }
}
