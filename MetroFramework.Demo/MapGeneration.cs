using SharpMap.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MetroFramework.Demo
{
    class MapGeneration
    {
        private SharpMap.Forms.MapBox map;
        SharpMap.Layers.VectorLayer baselayer;
        List<string> layerbase;

       
        public MapGeneration()
        {

        }

        public void AddMapbox(SharpMap.Forms.MapBox map)
        {
            layerbase = new List<string>();
            this.map = map;
            map.Refresh();
            baselayer = new SharpMap.Layers.VectorLayer("States");
            baselayer.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/SZ_DISTR/SZ_DISTR.shp", true);


            //构造土地样式
            VectorStyle style1 = new VectorStyle();
            style1.Fill = new SolidBrush(Color.FromArgb(232, 232, 232));

            VectorStyle style2 = new VectorStyle();
            style2.Fill = new SolidBrush(Color.FromArgb(255, 128, 0));

            VectorStyle style3 = new VectorStyle();
            style3.Fill = new SolidBrush(Color.FromArgb(204, 89, 68));

            VectorStyle style4 = new VectorStyle();
            style4.Fill = new SolidBrush(Color.FromArgb(86, 58, 255));

            //创建地图
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            styles.Add("罗湖区", style4);
            styles.Add("福田区", style2);
            styles.Add("盐田区", style3);
            styles.Add("龙岗区", style4);
            styles.Add("宝安区", style4);
            styles.Add("坪山新区", style2);
            styles.Add("南山区", style4);

            //分配主题
            baselayer.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("DISTRICT", styles, style1);
            map.Map.Layers.Add(baselayer);
            layerbase.Add(baselayer.LayerName);


            map.Map.ZoomToExtents();
            map.Refresh();
            map.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        public void AddLayer(SharpMap.Layers.VectorLayer Layeritem)
        {
            map.Map.Layers.Add(Layeritem);
            layerbase.Add(Layeritem.LayerName);
            map.Map.ZoomToExtents();
            map.Refresh();
        }


        public void DeleteLayer(SharpMap.Layers.VectorLayer Layeritem)
        {
            map.Map.Layers.RemoveAt(layerbase.IndexOf(Layeritem.LayerName));
            layerbase.Remove(Layeritem.LayerName);
            map.Refresh();
        }
        public void AddResultLayer()
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/SZ_DISTR/SZ_DISTR.shp", true);
            map.Map.Layers.Add(vlay);
        }
        public void addcheckbox( )
        {
            //MetroFramework.Controls.MetroCheckBox ch1 = new MetroFramework.Controls.MetroCheckBox();
            //ch1.AutoSize = true;
            //ch1.Checked = true;
            //ch1.CheckState = System.Windows.Forms.CheckState.Checked;
            //ch1.Location = new System.Drawing.Point(413, 582);
            //ch1.Name = cbname;
            //ch1.Size = new System.Drawing.Size(60, 17);
            //ch1.TabIndex = 4;
            //ch1.Text = cbtext;
           
            
        }

    
    }
}
