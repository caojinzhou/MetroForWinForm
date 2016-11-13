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
            style1.Fill = new SolidBrush(Color.FromArgb(0, 176, 192));

            VectorStyle style2 = new VectorStyle();
            style2.Fill = new SolidBrush(Color.FromArgb(64, 128, 128));

            VectorStyle style3 = new VectorStyle();
            style3.Fill = new SolidBrush(Color.FromArgb(85, 165, 247));

            VectorStyle style4 = new VectorStyle();
            style4.Fill = new SolidBrush(Color.FromArgb(255, 127, 1));

            //创建地图
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            styles.Add("罗湖区", style1);
            styles.Add("福田区", style2);
            styles.Add("盐田区", style3);
            styles.Add("龙岗区", style2);
            styles.Add("宝安区", style1);
            styles.Add("坪山新区", style4);
            styles.Add("南山区", style3);
            styles.Add("龙华新区", style4);
            styles.Add("大鹏新区", style2);
            styles.Add("光明新区", style3);
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

        public void HideLayer(SharpMap.Layers.VectorLayer Layeritem)
        {
            //map.Map.Layers.
        }

        public void AddResultLayer()
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/SZ_DISTR/SZ_DISTR.shp", true);
            map.Map.Layers.Add(vlay);
        }
        public void addcheckbox( )
        {
            
        }

    
    }
}
