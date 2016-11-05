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
        private SharpMap.Forms.MapBox mapBox1;

        public MapGeneration()
        {

        }

        public void AddMapbox(SharpMap.Forms.MapBox mapBox1)
        {
            this.mapBox1 = mapBox1;
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

        public void AddLayer()
        {

        }

        public void HideLayer()
        {
           // mapBox1.Map.Layers
        }

        public void DeleteLayer()
        {

        }

        public void AddResultLayer()
        {

        }

    }
}
