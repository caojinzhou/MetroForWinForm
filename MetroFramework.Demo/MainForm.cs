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
using OSGeo.OGR;

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
        }//传递第一行是否是有效数据

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
                filename = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
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
            tra_tc.SelectedIndex = 1;
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
            tra_tc.SelectedIndex = 1;
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
            tra_tc.SelectedIndex = 1;
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
                if (tra_userlayer_cb1.Visible == false)
                {
                    tra_tc.SelectedIndex = 1;
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
                    tra_tc.SelectedIndex = 1;
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
                    tra_tc.SelectedIndex = 1;
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
            if (tra_input_tb.Text == string.Empty)
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
            tra_tc.SelectedIndex = 0;
            var path = tra_input_tb.Text;
            DataTable dt = new DataTable();
            dt.TableName = "数据预览";
            dt.Columns.Add("uid", typeof(string));
            dt.Columns.Add("time", typeof(string));
            dt.Columns.Add("locationid", typeof(string));
            dt.Columns.Add("lat", typeof(string));
            dt.Columns.Add("lon", typeof(string));
            //读入文件  
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string[] strArr = sr.ReadLine().Split(fengefu);

            string p1 = DataField[0];
            if (tital == "no")
            {
                List<string> YT = new List<string>();//没有表头；
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
                List<string> NT = new List<string>();//没有表头；
                for (int i = 1; i < 6; i++)
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

        //尝试shp是否成功按钮
        private void button1_Click(object sender, EventArgs e)
        {
            lines();
        }

        //生成点shp的函数
        public void pint()
        {            
            string shpname= System.IO.Path.GetFileNameWithoutExtension(tra_input_tb.Text);//生产的shp文件名为输入文件的文件名；
            //注册Ogr库
            string pszDriverName = "ESRI Shapefile";
            OSGeo.OGR.Ogr.RegisterAll();
            //调用对Shape文件读写的Driver接口
            OSGeo.OGR.Driver poDriver = OSGeo.OGR.Ogr.GetDriverByName(pszDriverName);
            if (poDriver == null)
            {
                MessageBox.Show("Driver Error");
            }
            OSGeo.GDAL.Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");            
            //用此Driver创建Shape文件//数据源
            OSGeo.OGR.DataSource poDS;
            poDS = poDriver.CreateDataSource("D:\\SHP_TRY" , null);
            if (poDS == null)
            {
                MessageBox.Show("DataSource Creation Error");
            }
            //创建层Layer
            OSGeo.OGR.Layer poLayer;
            poLayer = poDS.CreateLayer(shpname, null, OSGeo.OGR.wkbGeometryType.wkbPoint, null);//shpname为提取输入TXT的文件名为shp文件文件名；
            if (poLayer == null)
            {
                MessageBox.Show("Layer Creation Failed");
            }            
            //创建属性表!!!!!这里是根据基站的TXT的做的实验以后可以改数据
            OSGeo.OGR.FieldDefn oField0 = new OSGeo.OGR.FieldDefn("uid", OSGeo.OGR.FieldType.OFTString);
            oField0.SetWidth(16);
            OSGeo.OGR.FieldDefn oField1 = new OSGeo.OGR.FieldDefn("time", OSGeo.OGR.FieldType.OFTString);
            OSGeo.OGR.FieldDefn oField2 = new OSGeo.OGR.FieldDefn("locationid", OSGeo.OGR.FieldType.OFTString);
            OSGeo.OGR.FieldDefn oField3 = new OSGeo.OGR.FieldDefn("lat", OSGeo.OGR.FieldType.OFTString);
            OSGeo.OGR.FieldDefn oField4 = new OSGeo.OGR.FieldDefn("lon", OSGeo.OGR.FieldType.OFTInteger);
            poLayer.CreateField(oField0, 1);
            poLayer.CreateField(oField2, 2);
            poLayer.CreateField(oField0, 3);
            poLayer.CreateField(oField0, 4);
            poLayer.CreateField(oField0, 5);
            
            //创建一个Feature,一个Point
            OSGeo.OGR.Feature poFeature = new OSGeo.OGR.Feature(poLayer.GetLayerDefn());
            OSGeo.OGR.Geometry pt = new OSGeo.OGR.Geometry(OSGeo.OGR.wkbGeometryType.wkbPoint);            
          
 
            string path = tra_input_tb.Text;//TXT输入路径；
            string l;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            while ((l = sr.ReadLine()) != null)
            {
                string[] strArr = sr.ReadLine().Split('\t');
                //属性表赋值
                poFeature.SetField(0, strArr[0]);
                poFeature.SetField(1, strArr[4]);
                poFeature.SetField(2, strArr[3]);
                poFeature.SetField(3, strArr[1]);
                poFeature.SetField(4, strArr[2]);
                //添加坐标点
                pt.AddPoint(Convert.ToDouble(strArr[2]), Convert.ToDouble(strArr[1]), 0);
                poFeature.SetGeometry(pt);
                //将带有坐标及属性的Feature要素点写入Layer中
                poLayer.CreateFeature(poFeature);
            }
            //关闭文件读写
            poFeature.Dispose();
            poDS.Dispose();
            MessageBox.Show("生成文件在：D:\\SHP_TRY！");
        }
       
        //生成的线shp函数
        public void lines()
        {
            double x = 0;
            double y = 0;
            int z = 0;            
            string pszDriverName = "ESRI Shapefile";
            OSGeo.OGR.Ogr.RegisterAll();
            OSGeo.OGR.Driver poDriver = OSGeo.OGR.Ogr.GetDriverByName(pszDriverName);
            if (poDriver == null)
            {
                MessageBox.Show("Driver Error");
            }
            OSGeo.GDAL.Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");

            //用此Driver创建Shape文件//数据源
            OSGeo.OGR.DataSource poDS;
            poDS = poDriver.CreateDataSource("D:\\SHP_TRY", null);//指定存储文件
            if (poDS == null)
            {
                MessageBox.Show("DataSource Creation Error");
            }
            // 创建图层
            Layer oLayer = poDS.CreateLayer("lines", null, wkbGeometryType.wkbLineString, null);//图层名字为【CreateLayer（名字，类型，null）】
            if (oLayer == null)
            {
                Console.WriteLine("图层创建失败！\n");
                return;
            }
            // 下面创建属性表
            // 先创建一个叫FieldID的整型属性
            FieldDefn oFieldID = new FieldDefn("FieldID", FieldType.OFTInteger);
            oLayer.CreateField(oFieldID, 0);
            // 再创建一个叫FeatureName的字符型属性，字符长度为50
            FieldDefn oFieldName = new FieldDefn("FieldName", FieldType.OFTString);
            oFieldName.SetWidth(100);
            oLayer.CreateField(oFieldName, 1);
            FeatureDefn oDefn = oLayer.GetLayerDefn();
            // 创建要素
            Feature oFeatureTriangle = new Feature(oDefn);
            OSGeo.OGR.Geometry pt = new OSGeo.OGR.Geometry(OSGeo.OGR.wkbGeometryType.wkbLineString);
            oFeatureTriangle.SetField(0, 1);
            oFeatureTriangle.SetField(1, "line_try");//线要素名字

            //写入属性！！！！！！这里是根据基站的TXT的做的实验以后可以改数据，文件地址根据实际情况可以修改
            string path = "C:\\Users\\Tianh\\Desktop\\station.txt";
            string l;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            while ((l = sr.ReadLine()) != null)
            {
                string[] strArr = sr.ReadLine().Split('\t');
                x = Convert.ToDouble(strArr[2]);//经度
                y = Convert.ToDouble(strArr[1]);//纬度
                pt.AddPoint(x, y, z);
            }
            oFeatureTriangle.SetGeometry(pt);
            oLayer.CreateFeature(oFeatureTriangle);
            oFeatureTriangle.Dispose();
            poDS.Dispose();
            MessageBox.Show("生成文件在：D:\\SHP_TRY！");
        }

        //生成面shp函数
        public void surface()
        {
            string pszDriverName = "ESRI Shapefile";
            OSGeo.OGR.Ogr.RegisterAll();
            OSGeo.OGR.Driver poDriver = OSGeo.OGR.Ogr.GetDriverByName(pszDriverName);
            if (poDriver == null)
            {
                MessageBox.Show("Driver Error");
            }
            OSGeo.GDAL.Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
            //用此Driver创建Shape文件//数据源
            OSGeo.OGR.DataSource poDS;
            poDS = poDriver.CreateDataSource("D:\\SHP_TRY", null);
            if (poDS == null)
            {
                MessageBox.Show("DataSource Creation Error");
            }
            // 创建图层，创建一个多边形图层，这里没有指定空间参考，如果需要的话，需要在这里进行指定
            Layer oLayer = poDS.CreateLayer("TestPolygon", null, wkbGeometryType.wkbPolygon, null);
            if (oLayer == null)
            {
                MessageBox.Show("图层创建失败！\n");
                return;
            }

            // 下面创建属性表
            // 先创建一个叫FieldID的整型属性
            FieldDefn oFieldID = new FieldDefn("FieldID", FieldType.OFTInteger);
            oLayer.CreateField(oFieldID, 1);
            // 再创建一个叫FeatureName的字符型属性，字符长度为50
            FieldDefn oFieldName = new FieldDefn("FieldName", FieldType.OFTString);
            oFieldName.SetWidth(100);
            oLayer.CreateField(oFieldName, 1);
            FeatureDefn oDefn = oLayer.GetLayerDefn();

            // 创建几何图形要素
            string CS = "";
            string zc = "";
            string zj = "";
            string start_PT = "";
            double x;
            double y;
            Feature oFeatureRectangle = new Feature(oDefn);
            oFeatureRectangle.SetField(0, 1);
            oFeatureRectangle.SetField(1, "surface");
                       
            for (int i = 0; i <5; i++)
            {
                x = i * i; //X,Y是假设的数据，以后可以更加实际坐标点进行填充
                y = i + 4;
                zc = x + " " + y;
                if (i == 0)
                {
                    start_PT = zc; //记录第一个坐标
                }                
                zj = zj + zc + ","; //坐标之间用“，”隔开
            }
            zj = zj + start_PT; //形成闭合的环

            //在POLYGON中添加坐标
            CS = "POLYGON ((" + zj + "))";
            Geometry geomRectangle = Geometry.CreateFromWkt(CS);
            oFeatureRectangle.SetGeometry(geomRectangle);
            oLayer.CreateFeature(oFeatureRectangle);
            oFeatureRectangle.Dispose();
            poDS.Dispose();
            MessageBox.Show("生成文件在：D:\\SHP_TRY！");
        }
    }
}
