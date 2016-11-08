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

        public MapGeneration()
        {

        }

        public void AddMapbox(SharpMap.Forms.MapBox map)
        {
            this.map = map;
            map.Refresh();
            SharpMap.Layers.VectorLayer baselayer = new SharpMap.Layers.VectorLayer("States");
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


            map.Map.ZoomToExtents();
            map.Refresh();
            map.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        public void AddLayer(string str, SharpMap.Layers.VectorLayer layername)
        {
            
            layername = new SharpMap.Layers.VectorLayer("road");
            layername.DataSource = new SharpMap.Data.Providers.ShapeFile(str, true);
            VectorStyle style1 = new VectorStyle();
            style1.Fill = new SolidBrush(Color.FromArgb(232, 232, 232));
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            layername.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("DISTRICT", styles, style1);
            map.Map.Layers.Add(layername);
            map.Map.ZoomToExtents();
            map.Refresh();
            map.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;

        }


        public void DeleteLayer(SharpMap.Layers.VectorLayer layername)
        {
            //SharpMap.Layers.VectorLayer roadmap;

            map.Map.Layers.Remove(layername);
            map.Refresh();
        }

        public void AddResultLayer()
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@"../../../map/SZ_DISTR/SZ_DISTR.shp", true);
            map.Map.Layers.Add(vlay);
        }

    }
}
