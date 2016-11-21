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
using System.Linq;
using System.Data;

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
        string filename;
       
        //定义子窗体传值类型和函数
        List<string> DataField = new List<string>();
        public List<string> Matchvalue 
        {
            get
            {
                return DataField;
            }
            set  
            {
                DataField = value;
            }
        }//传递原数据的列匹配情况
        char fengefu;
        public char chuandifenge
        {
            set
            {
                fengefu = value;
            }
        }//传递占位符类型
        string tital;
        public string ischoosett
        {
            set
            {
                tital = value;
            }
        }//传递第一行是否有有效数据
     
        //主程序
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
            opf.InitialDirectory = "F:\\";
            opf.Filter = "文本文件(*.txt)|*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                 tra_input_tb.Text = opf.FileName;
                 filename=System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
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
            
            // 假设文件为 c:\data.txt
            string path = tra_input_tb.Text;
            //
            if (tra_input_tb.Text == string.Empty )
            {
                MessageBox.Show("对不起，路径不能为空！");
            }
            else
            {
                LeadData Fm = new LeadData();//实例化一个FormS窗口
                Fm.comevalue1 = path;//设置FormS中string1的值
                Fm.comevalue2 = filename;
                Fm.Owner = this;        //重要的一步，主要是使FrmS的Owner指针指向父窗体
                Fm.SetValue();//设置子窗体显示文件名
                Fm.ShowDialog();
            }
        }
        //在dataGridView1，中显示数据，在子窗体，传值时激发此函数
        public void AddTableData()
        {
          
            var path = tra_input_tb.Text;
            DataTable dt = new DataTable();
            dt.Columns.Add("uid", typeof(string));
            dt.Columns.Add("time", typeof(string));
            dt.Columns.Add("locationid", typeof(string));
            dt.Columns.Add("lat", typeof(string));
            dt.Columns.Add("lon", typeof(string));

            //读入文件  
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string[] strArr = sr.ReadLine().Split(fengefu);
           
            string p1 = DataField[0];
            if (tital  == "no")
            {
                List<string> YT = new List<string>();
                for (int j = 0; j < strArr.Length; j++)
                {
                    YT.Add(strArr[j]);
                }
                for (int i = 0; i < 20; i++)
                {
                    string[] items = sr.ReadLine().Split(fengefu);
                    DataRow dr = dt.NewRow();
                    dr[0] = items[YT.IndexOf(DataField[0])];
                    dr[1] = items[YT.IndexOf(DataField[1])];
                    dr[2] = items[YT.IndexOf(DataField[2])];
                    dr[3] = items[YT.IndexOf(DataField[3])];
                    dr[4] = items[YT.IndexOf(DataField[4])];

                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                YT.Clear();
                DataField.Clear();
            }
            if (tital == "yes")
            {
                List<string> NT = new List<string>();
                for (int i = 1; i<6;i++)
                {
                    NT.Add("Field" + i);
                }
                for (int i = 0; i < 20; i++)
                {
                    string[] items = sr.ReadLine().Split(fengefu);
                    DataRow dr = dt.NewRow();
                    dr[0] = items[NT.IndexOf(DataField[0])];
                    dr[1] = items[NT.IndexOf(DataField[1])];
                    dr[2] = items[NT.IndexOf(DataField[2])];
                    dr[3] = items[NT.IndexOf(DataField[3])];
                    dr[4] = items[NT.IndexOf(DataField[4])];

                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                NT.Clear();
                DataField.Clear();
            }
 
           
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
