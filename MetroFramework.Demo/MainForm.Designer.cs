using System.Security.AccessControl;
using MetroFramework.Controls;

namespace MetroFramework.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormTabControl = new MetroFramework.Controls.MetroTabControl();
            this.traTabPage = new MetroFramework.Controls.MetroTabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tra_tc = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tramap = new SharpMap.Forms.MapBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tra_Progressbar_gb = new System.Windows.Forms.GroupBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.tra_Progressbar = new MetroFramework.Controls.MetroProgressBar();
            this.tra_layer_gb = new System.Windows.Forms.GroupBox();
            this.tra_addlayer_bt = new System.Windows.Forms.Button();
            this.tra_userlayer_cb3 = new MetroFramework.Controls.MetroCheckBox();
            this.tra_userlayer_cb2 = new MetroFramework.Controls.MetroCheckBox();
            this.tra_baselayer_cb = new MetroFramework.Controls.MetroCheckBox();
            this.tra_userlayer_cb1 = new MetroFramework.Controls.MetroCheckBox();
            this.tra_Result_cb = new MetroFramework.Controls.MetroCheckBox();
            this.tra_next_bt = new System.Windows.Forms.Button();
            this.tra_parameter_gb = new System.Windows.Forms.GroupBox();
            this.tra_start_bt = new System.Windows.Forms.Button();
            this.tra_pm_tb2 = new System.Windows.Forms.TextBox();
            this.trapala2 = new System.Windows.Forms.Label();
            this.tra_pm_tb1 = new System.Windows.Forms.TextBox();
            this.trapalb1 = new System.Windows.Forms.Label();
            this.tra_input_bt = new System.Windows.Forms.Button();
            this.tra_output_bt = new System.Windows.Forms.Button();
            this.tra_input_tb = new System.Windows.Forms.TextBox();
            this.tra_output_tb = new System.Windows.Forms.TextBox();
            this.tra_cancel_bt = new System.Windows.Forms.Button();
            this.stopptTabPage = new MetroFramework.Controls.MetroTabPage();
            this.stoppttc = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stoppt_map = new SharpMap.Forms.MapBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.stoppt_layer_gb = new System.Windows.Forms.GroupBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox9 = new MetroFramework.Controls.MetroCheckBox();
            this.stoppt_baselayer_cb = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox20 = new MetroFramework.Controls.MetroCheckBox();
            this.stoppt_userlayer_cb1 = new MetroFramework.Controls.MetroCheckBox();
            this.stoppt_processB_gb = new System.Windows.Forms.GroupBox();
            this.stoppt_processbar = new MetroFramework.Controls.MetroProgressBar();
            this.stoppt_Cancel_bt = new System.Windows.Forms.Button();
            this.stoppt_Next_bt = new System.Windows.Forms.Button();
            this.stoppt_Back_bt = new System.Windows.Forms.Button();
            this.stoppt_pm_gb = new System.Windows.Forms.GroupBox();
            this.stoppt_start_bt = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stoppt_pm_tb2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stoppt_pm_tb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stoppt_input_bt = new System.Windows.Forms.Button();
            this.stoppt_output_bt = new System.Windows.Forms.Button();
            this.stoppt_input_tb = new System.Windows.Forms.TextBox();
            this.stoppt_output_tb = new System.Windows.Forms.TextBox();
            this.actTabPage = new MetroFramework.Controls.MetroTabPage();
            this.activityas_BP_gb = new System.Windows.Forms.GroupBox();
            this.activityas_PB = new MetroFramework.Controls.MetroProgressBar();
            this.activityas_layer_gb = new System.Windows.Forms.GroupBox();
            this.activityas_pm_cb2 = new MetroFramework.Controls.MetroCheckBox();
            this.activityas_pm_cb1 = new MetroFramework.Controls.MetroCheckBox();
            this.activityas_cancel_bt = new System.Windows.Forms.Button();
            this.activityas_next_bt = new System.Windows.Forms.Button();
            this.activityas_back_bt = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.activityas_pm_gb = new System.Windows.Forms.GroupBox();
            this.activityas_pm_cbb = new System.Windows.Forms.ComboBox();
            this.activityas_pm_tb2 = new System.Windows.Forms.TextBox();
            this.activityas_start_bt = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.activityas_pm_tb = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.activityas_pm_tb1 = new System.Windows.Forms.TextBox();
            this.travelTabPage = new MetroFramework.Controls.MetroTabPage();
            this.tripas_PB_gb = new System.Windows.Forms.GroupBox();
            this.tripas_PB = new MetroFramework.Controls.MetroProgressBar();
            this.tripas_layer_gb = new System.Windows.Forms.GroupBox();
            this.metroCheckBox13 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox12 = new MetroFramework.Controls.MetroCheckBox();
            this.tripas_cancel_bt = new System.Windows.Forms.Button();
            this.tripas_back_bt = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tripas_pm_gb = new System.Windows.Forms.GroupBox();
            this.tripas_start_bt = new System.Windows.Forms.Button();
            this.tripas_pm_tb3 = new System.Windows.Forms.TextBox();
            this.tripas_pm_tb2 = new System.Windows.Forms.TextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tripas_pm_tb1 = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.batchTabPage = new MetroFramework.Controls.MetroTabPage();
            this.batch_layer_gb = new System.Windows.Forms.GroupBox();
            this.batch_layer_cb2 = new MetroFramework.Controls.MetroCheckBox();
            this.batch_layer_cb1 = new MetroFramework.Controls.MetroCheckBox();
            this.batch_PB_gb = new System.Windows.Forms.GroupBox();
            this.batch_PB = new MetroFramework.Controls.MetroProgressBar();
            this.batch_stop_bt = new System.Windows.Forms.Button();
            this.batch_cancel_bt = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.batch_pm_gb = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.batch_tripas_cb = new MetroFramework.Controls.MetroCheckBox();
            this.batch_activityas_cb = new MetroFramework.Controls.MetroCheckBox();
            this.batch_stoppt_cb = new MetroFramework.Controls.MetroCheckBox();
            this.batch_tra_cb = new MetroFramework.Controls.MetroCheckBox();
            this.batch_output_tb = new System.Windows.Forms.TextBox();
            this.batch_input_tb = new System.Windows.Forms.TextBox();
            this.batch_output_bt = new System.Windows.Forms.Button();
            this.batch_input_bt = new System.Windows.Forms.Button();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroProgressBar6 = new MetroFramework.Controls.MetroProgressBar();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.metroCheckBox27 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox26 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox25 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox24 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox23 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox22 = new MetroFramework.Controls.MetroCheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.mapBox2 = new SharpMap.Forms.MapBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.删除该图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormTabControl.SuspendLayout();
            this.traTabPage.SuspendLayout();
            this.tra_tc.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tra_Progressbar_gb.SuspendLayout();
            this.tra_layer_gb.SuspendLayout();
            this.tra_parameter_gb.SuspendLayout();
            this.stopptTabPage.SuspendLayout();
            this.stoppttc.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.stoppt_layer_gb.SuspendLayout();
            this.stoppt_processB_gb.SuspendLayout();
            this.stoppt_pm_gb.SuspendLayout();
            this.actTabPage.SuspendLayout();
            this.activityas_BP_gb.SuspendLayout();
            this.activityas_layer_gb.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.activityas_pm_gb.SuspendLayout();
            this.travelTabPage.SuspendLayout();
            this.tripas_PB_gb.SuspendLayout();
            this.tripas_layer_gb.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tripas_pm_gb.SuspendLayout();
            this.batchTabPage.SuspendLayout();
            this.batch_layer_gb.SuspendLayout();
            this.batch_PB_gb.SuspendLayout();
            this.batch_pm_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTabControl
            // 
            this.FormTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormTabControl.Controls.Add(this.traTabPage);
            this.FormTabControl.Controls.Add(this.stopptTabPage);
            this.FormTabControl.Controls.Add(this.actTabPage);
            this.FormTabControl.Controls.Add(this.travelTabPage);
            this.FormTabControl.Controls.Add(this.batchTabPage);
            this.FormTabControl.Location = new System.Drawing.Point(21, 45);
            this.FormTabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FormTabControl.Multiline = true;
            this.FormTabControl.Name = "FormTabControl";
            this.FormTabControl.SelectedIndex = 0;
            this.FormTabControl.Size = new System.Drawing.Size(948, 648);
            this.FormTabControl.TabIndex = 0;
            this.FormTabControl.UseSelectable = true;
            // 
            // traTabPage
            // 
            this.traTabPage.Controls.Add(this.button1);
            this.traTabPage.Controls.Add(this.tra_tc);
            this.traTabPage.Controls.Add(this.tra_Progressbar_gb);
            this.traTabPage.Controls.Add(this.tra_layer_gb);
            this.traTabPage.Controls.Add(this.tra_next_bt);
            this.traTabPage.Controls.Add(this.tra_parameter_gb);
            this.traTabPage.Controls.Add(this.tra_cancel_bt);
            this.traTabPage.HorizontalScrollbarBarColor = true;
            this.traTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.traTabPage.HorizontalScrollbarSize = 10;
            this.traTabPage.Location = new System.Drawing.Point(4, 39);
            this.traTabPage.Name = "traTabPage";
            this.traTabPage.Size = new System.Drawing.Size(940, 605);
            this.traTabPage.TabIndex = 6;
            this.traTabPage.Text = "轨迹生成";
            this.traTabPage.VerticalScrollbarBarColor = true;
            this.traTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.traTabPage.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "RTY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tra_tc
            // 
            this.tra_tc.Controls.Add(this.tabPage7);
            this.tra_tc.Controls.Add(this.tabPage1);
            this.tra_tc.Controls.Add(this.tabPage2);
            this.tra_tc.Location = new System.Drawing.Point(160, 7);
            this.tra_tc.Name = "tra_tc";
            this.tra_tc.SelectedIndex = 0;
            this.tra_tc.Size = new System.Drawing.Size(774, 518);
            this.tra_tc.TabIndex = 28;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(766, 492);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "数据";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(731, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tramap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tramap
            // 
            this.tramap.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.tramap.Cursor = System.Windows.Forms.Cursors.Default;
            this.tramap.FineZoomFactor = 10D;
            this.tramap.Location = new System.Drawing.Point(2, 2);
            this.tramap.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.tramap.Name = "tramap";
            this.tramap.QueryGrowFactor = 5F;
            this.tramap.QueryLayerIndex = 0;
            this.tramap.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tramap.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tramap.ShowProgressUpdate = false;
            this.tramap.Size = new System.Drawing.Size(768, 487);
            this.tramap.TabIndex = 0;
            this.tramap.Text = "mapBox2";
            this.tramap.WheelZoomMagnitude = -2D;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "数据处理结果"});
            this.listBox1.Location = new System.Drawing.Point(70, 367);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 88);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(562, 320);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tra_Progressbar_gb
            // 
            this.tra_Progressbar_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tra_Progressbar_gb.Controls.Add(this.metroLabel18);
            this.tra_Progressbar_gb.Controls.Add(this.tra_Progressbar);
            this.tra_Progressbar_gb.Location = new System.Drawing.Point(0, 531);
            this.tra_Progressbar_gb.Name = "tra_Progressbar_gb";
            this.tra_Progressbar_gb.Size = new System.Drawing.Size(937, 45);
            this.tra_Progressbar_gb.TabIndex = 27;
            this.tra_Progressbar_gb.TabStop = false;
            this.tra_Progressbar_gb.Text = "进度";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(848, 17);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(79, 20);
            this.metroLabel18.TabIndex = 35;
            this.metroLabel18.Text = "已完成20%";
            // 
            // tra_Progressbar
            // 
            this.tra_Progressbar.Location = new System.Drawing.Point(9, 16);
            this.tra_Progressbar.Name = "tra_Progressbar";
            this.tra_Progressbar.Size = new System.Drawing.Size(822, 23);
            this.tra_Progressbar.TabIndex = 34;
            this.tra_Progressbar.Value = 20;
            // 
            // tra_layer_gb
            // 
            this.tra_layer_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tra_layer_gb.Controls.Add(this.tra_addlayer_bt);
            this.tra_layer_gb.Controls.Add(this.tra_userlayer_cb3);
            this.tra_layer_gb.Controls.Add(this.tra_userlayer_cb2);
            this.tra_layer_gb.Controls.Add(this.tra_baselayer_cb);
            this.tra_layer_gb.Controls.Add(this.tra_userlayer_cb1);
            this.tra_layer_gb.Controls.Add(this.tra_Result_cb);
            this.tra_layer_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tra_layer_gb.Location = new System.Drawing.Point(0, 250);
            this.tra_layer_gb.Name = "tra_layer_gb";
            this.tra_layer_gb.Size = new System.Drawing.Size(150, 275);
            this.tra_layer_gb.TabIndex = 26;
            this.tra_layer_gb.TabStop = false;
            this.tra_layer_gb.Text = "图层操作";
            // 
            // tra_addlayer_bt
            // 
            this.tra_addlayer_bt.Location = new System.Drawing.Point(9, 222);
            this.tra_addlayer_bt.Name = "tra_addlayer_bt";
            this.tra_addlayer_bt.Size = new System.Drawing.Size(132, 23);
            this.tra_addlayer_bt.TabIndex = 6;
            this.tra_addlayer_bt.Text = "添加图层";
            this.tra_addlayer_bt.UseVisualStyleBackColor = true;
            this.tra_addlayer_bt.Click += new System.EventHandler(this.tra_addlayer_bt_Click);
            // 
            // tra_userlayer_cb3
            // 
            this.tra_userlayer_cb3.AutoSize = true;
            this.tra_userlayer_cb3.Location = new System.Drawing.Point(42, 185);
            this.tra_userlayer_cb3.Name = "tra_userlayer_cb3";
            this.tra_userlayer_cb3.Size = new System.Drawing.Size(60, 17);
            this.tra_userlayer_cb3.TabIndex = 5;
            this.tra_userlayer_cb3.Text = "添加三";
            this.toolTip1.SetToolTip(this.tra_userlayer_cb3, "点击右键删除图层");
            this.tra_userlayer_cb3.UseSelectable = true;
            this.tra_userlayer_cb3.CheckedChanged += new System.EventHandler(this.tra_userlayer_cb3_CheckedChanged);
            this.tra_userlayer_cb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deletlayer_MouseDown);
            // 
            // tra_userlayer_cb2
            // 
            this.tra_userlayer_cb2.AutoSize = true;
            this.tra_userlayer_cb2.Location = new System.Drawing.Point(42, 146);
            this.tra_userlayer_cb2.Name = "tra_userlayer_cb2";
            this.tra_userlayer_cb2.Size = new System.Drawing.Size(60, 17);
            this.tra_userlayer_cb2.TabIndex = 4;
            this.tra_userlayer_cb2.Text = "添加二";
            this.toolTip1.SetToolTip(this.tra_userlayer_cb2, "点击右键删除图层");
            this.tra_userlayer_cb2.UseSelectable = true;
            this.tra_userlayer_cb2.CheckedChanged += new System.EventHandler(this.tra_userlayer_cb2_CheckedChanged);
            this.tra_userlayer_cb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deletlayer_MouseDown);
            // 
            // tra_baselayer_cb
            // 
            this.tra_baselayer_cb.AutoSize = true;
            this.tra_baselayer_cb.Location = new System.Drawing.Point(9, 29);
            this.tra_baselayer_cb.Name = "tra_baselayer_cb";
            this.tra_baselayer_cb.Size = new System.Drawing.Size(72, 17);
            this.tra_baselayer_cb.TabIndex = 3;
            this.tra_baselayer_cb.Text = "深圳底图";
            this.tra_baselayer_cb.UseSelectable = true;
            // 
            // tra_userlayer_cb1
            // 
            this.tra_userlayer_cb1.AutoSize = true;
            this.tra_userlayer_cb1.Location = new System.Drawing.Point(42, 109);
            this.tra_userlayer_cb1.Name = "tra_userlayer_cb1";
            this.tra_userlayer_cb1.Size = new System.Drawing.Size(60, 17);
            this.tra_userlayer_cb1.TabIndex = 2;
            this.tra_userlayer_cb1.Text = "添加一";
            this.toolTip1.SetToolTip(this.tra_userlayer_cb1, "点击右键删除图层");
            this.tra_userlayer_cb1.UseSelectable = true;
            this.tra_userlayer_cb1.CheckedChanged += new System.EventHandler(this.tra_userlayer_cb1_CheckedChanged);
            this.tra_userlayer_cb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deletlayer_MouseDown);
            // 
            // tra_Result_cb
            // 
            this.tra_Result_cb.AutoSize = true;
            this.tra_Result_cb.Location = new System.Drawing.Point(9, 67);
            this.tra_Result_cb.Name = "tra_Result_cb";
            this.tra_Result_cb.Size = new System.Drawing.Size(72, 17);
            this.tra_Result_cb.TabIndex = 1;
            this.tra_Result_cb.Text = "结果图层";
            this.tra_Result_cb.UseSelectable = true;
            // 
            // tra_next_bt
            // 
            this.tra_next_bt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tra_next_bt.Location = new System.Drawing.Point(306, 582);
            this.tra_next_bt.Name = "tra_next_bt";
            this.tra_next_bt.Size = new System.Drawing.Size(75, 23);
            this.tra_next_bt.TabIndex = 25;
            this.tra_next_bt.Text = "下一步";
            this.tra_next_bt.UseVisualStyleBackColor = true;
            this.tra_next_bt.Click += new System.EventHandler(this.tra_next_bt_Click);
            // 
            // tra_parameter_gb
            // 
            this.tra_parameter_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tra_parameter_gb.Controls.Add(this.tra_start_bt);
            this.tra_parameter_gb.Controls.Add(this.tra_pm_tb2);
            this.tra_parameter_gb.Controls.Add(this.trapala2);
            this.tra_parameter_gb.Controls.Add(this.tra_pm_tb1);
            this.tra_parameter_gb.Controls.Add(this.trapalb1);
            this.tra_parameter_gb.Controls.Add(this.tra_input_bt);
            this.tra_parameter_gb.Controls.Add(this.tra_output_bt);
            this.tra_parameter_gb.Controls.Add(this.tra_input_tb);
            this.tra_parameter_gb.Controls.Add(this.tra_output_tb);
            this.tra_parameter_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tra_parameter_gb.Location = new System.Drawing.Point(0, 7);
            this.tra_parameter_gb.Name = "tra_parameter_gb";
            this.tra_parameter_gb.Size = new System.Drawing.Size(150, 225);
            this.tra_parameter_gb.TabIndex = 24;
            this.tra_parameter_gb.TabStop = false;
            this.tra_parameter_gb.Text = "路径与参数";
            // 
            // tra_start_bt
            // 
            this.tra_start_bt.Location = new System.Drawing.Point(9, 189);
            this.tra_start_bt.Name = "tra_start_bt";
            this.tra_start_bt.Size = new System.Drawing.Size(132, 23);
            this.tra_start_bt.TabIndex = 39;
            this.tra_start_bt.Text = "开始";
            this.tra_start_bt.UseVisualStyleBackColor = true;
            this.tra_start_bt.Click += new System.EventHandler(this.tra_start_bt_Click);
            // 
            // tra_pm_tb2
            // 
            this.tra_pm_tb2.Location = new System.Drawing.Point(59, 147);
            this.tra_pm_tb2.Name = "tra_pm_tb2";
            this.tra_pm_tb2.Size = new System.Drawing.Size(82, 23);
            this.tra_pm_tb2.TabIndex = 38;
            // 
            // trapala2
            // 
            this.trapala2.AutoSize = true;
            this.trapala2.Location = new System.Drawing.Point(6, 153);
            this.trapala2.Name = "trapala2";
            this.trapala2.Size = new System.Drawing.Size(44, 17);
            this.trapala2.TabIndex = 35;
            this.trapala2.Text = "参数一";
            // 
            // tra_pm_tb1
            // 
            this.tra_pm_tb1.Location = new System.Drawing.Point(59, 108);
            this.tra_pm_tb1.Name = "tra_pm_tb1";
            this.tra_pm_tb1.Size = new System.Drawing.Size(82, 23);
            this.tra_pm_tb1.TabIndex = 36;
            // 
            // trapalb1
            // 
            this.trapalb1.AutoSize = true;
            this.trapalb1.Location = new System.Drawing.Point(6, 114);
            this.trapalb1.Name = "trapalb1";
            this.trapalb1.Size = new System.Drawing.Size(44, 17);
            this.trapalb1.TabIndex = 37;
            this.trapalb1.Text = "参数二";
            // 
            // tra_input_bt
            // 
            this.tra_input_bt.Location = new System.Drawing.Point(9, 31);
            this.tra_input_bt.Name = "tra_input_bt";
            this.tra_input_bt.Size = new System.Drawing.Size(41, 23);
            this.tra_input_bt.TabIndex = 29;
            this.tra_input_bt.Text = "输入";
            this.tra_input_bt.UseVisualStyleBackColor = true;
            this.tra_input_bt.Click += new System.EventHandler(this.tra_input_bt_Click_1);
            // 
            // tra_output_bt
            // 
            this.tra_output_bt.Location = new System.Drawing.Point(9, 70);
            this.tra_output_bt.Name = "tra_output_bt";
            this.tra_output_bt.Size = new System.Drawing.Size(41, 23);
            this.tra_output_bt.TabIndex = 31;
            this.tra_output_bt.Text = "输出";
            this.tra_output_bt.UseVisualStyleBackColor = true;
            this.tra_output_bt.Click += new System.EventHandler(this.tra_output_bt_Click_1);
            // 
            // tra_input_tb
            // 
            this.tra_input_tb.Location = new System.Drawing.Point(59, 31);
            this.tra_input_tb.Name = "tra_input_tb";
            this.tra_input_tb.Size = new System.Drawing.Size(82, 23);
            this.tra_input_tb.TabIndex = 30;
            // 
            // tra_output_tb
            // 
            this.tra_output_tb.Location = new System.Drawing.Point(59, 70);
            this.tra_output_tb.Name = "tra_output_tb";
            this.tra_output_tb.Size = new System.Drawing.Size(82, 23);
            this.tra_output_tb.TabIndex = 32;
            // 
            // tra_cancel_bt
            // 
            this.tra_cancel_bt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tra_cancel_bt.Location = new System.Drawing.Point(501, 579);
            this.tra_cancel_bt.Name = "tra_cancel_bt";
            this.tra_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.tra_cancel_bt.TabIndex = 23;
            this.tra_cancel_bt.Text = "取消";
            this.tra_cancel_bt.UseVisualStyleBackColor = true;
            // 
            // stopptTabPage
            // 
            this.stopptTabPage.AutoScroll = true;
            this.stopptTabPage.Controls.Add(this.stoppttc);
            this.stopptTabPage.Controls.Add(this.stoppt_layer_gb);
            this.stopptTabPage.Controls.Add(this.stoppt_processB_gb);
            this.stopptTabPage.Controls.Add(this.stoppt_Cancel_bt);
            this.stopptTabPage.Controls.Add(this.stoppt_Next_bt);
            this.stopptTabPage.Controls.Add(this.stoppt_Back_bt);
            this.stopptTabPage.Controls.Add(this.stoppt_pm_gb);
            this.stopptTabPage.HorizontalScrollbar = true;
            this.stopptTabPage.HorizontalScrollbarBarColor = false;
            this.stopptTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.stopptTabPage.HorizontalScrollbarSize = 9;
            this.stopptTabPage.Location = new System.Drawing.Point(4, 39);
            this.stopptTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stopptTabPage.Name = "stopptTabPage";
            this.stopptTabPage.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.stopptTabPage.Size = new System.Drawing.Size(940, 605);
            this.stopptTabPage.TabIndex = 0;
            this.stopptTabPage.Text = "停留探测";
            this.stopptTabPage.VerticalScrollbar = true;
            this.stopptTabPage.VerticalScrollbarBarColor = true;
            this.stopptTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.stopptTabPage.VerticalScrollbarSize = 10;
            // 
            // stoppttc
            // 
            this.stoppttc.Controls.Add(this.tabPage3);
            this.stoppttc.Controls.Add(this.tabPage4);
            this.stoppttc.Location = new System.Drawing.Point(160, 7);
            this.stoppttc.Name = "stoppttc";
            this.stoppttc.SelectedIndex = 0;
            this.stoppttc.Size = new System.Drawing.Size(774, 518);
            this.stoppttc.TabIndex = 31;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stoppt_map);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(766, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "地图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stoppt_map
            // 
            this.stoppt_map.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.stoppt_map.Cursor = System.Windows.Forms.Cursors.Default;
            this.stoppt_map.FineZoomFactor = 10D;
            this.stoppt_map.Location = new System.Drawing.Point(3, 3);
            this.stoppt_map.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.stoppt_map.Name = "stoppt_map";
            this.stoppt_map.QueryGrowFactor = 5F;
            this.stoppt_map.QueryLayerIndex = 0;
            this.stoppt_map.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.stoppt_map.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.stoppt_map.ShowProgressUpdate = false;
            this.stoppt_map.Size = new System.Drawing.Size(757, 486);
            this.stoppt_map.TabIndex = 0;
            this.stoppt_map.Text = "mapBox2";
            this.stoppt_map.WheelZoomMagnitude = -2D;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(766, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "统计图";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // stoppt_layer_gb
            // 
            this.stoppt_layer_gb.BackColor = System.Drawing.SystemColors.Window;
            this.stoppt_layer_gb.Controls.Add(this.metroCheckBox7);
            this.stoppt_layer_gb.Controls.Add(this.metroCheckBox8);
            this.stoppt_layer_gb.Controls.Add(this.metroCheckBox9);
            this.stoppt_layer_gb.Controls.Add(this.stoppt_baselayer_cb);
            this.stoppt_layer_gb.Controls.Add(this.metroCheckBox20);
            this.stoppt_layer_gb.Controls.Add(this.stoppt_userlayer_cb1);
            this.stoppt_layer_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stoppt_layer_gb.Location = new System.Drawing.Point(0, 250);
            this.stoppt_layer_gb.Name = "stoppt_layer_gb";
            this.stoppt_layer_gb.Size = new System.Drawing.Size(150, 275);
            this.stoppt_layer_gb.TabIndex = 30;
            this.stoppt_layer_gb.TabStop = false;
            this.stoppt_layer_gb.Text = "图层操作";
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Location = new System.Drawing.Point(8, 229);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox7.TabIndex = 6;
            this.metroCheckBox7.Text = "添加四";
            this.metroCheckBox7.UseSelectable = true;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Location = new System.Drawing.Point(8, 191);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox8.TabIndex = 5;
            this.metroCheckBox8.Text = "添加三";
            this.metroCheckBox8.UseSelectable = true;
            // 
            // metroCheckBox9
            // 
            this.metroCheckBox9.AutoSize = true;
            this.metroCheckBox9.Location = new System.Drawing.Point(8, 153);
            this.metroCheckBox9.Name = "metroCheckBox9";
            this.metroCheckBox9.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox9.TabIndex = 4;
            this.metroCheckBox9.Text = "添加二";
            this.metroCheckBox9.UseSelectable = true;
            // 
            // stoppt_baselayer_cb
            // 
            this.stoppt_baselayer_cb.AutoSize = true;
            this.stoppt_baselayer_cb.Location = new System.Drawing.Point(8, 36);
            this.stoppt_baselayer_cb.Name = "stoppt_baselayer_cb";
            this.stoppt_baselayer_cb.Size = new System.Drawing.Size(48, 17);
            this.stoppt_baselayer_cb.TabIndex = 3;
            this.stoppt_baselayer_cb.Text = "底图";
            this.stoppt_baselayer_cb.UseSelectable = true;
            // 
            // metroCheckBox20
            // 
            this.metroCheckBox20.AutoSize = true;
            this.metroCheckBox20.Location = new System.Drawing.Point(8, 111);
            this.metroCheckBox20.Name = "metroCheckBox20";
            this.metroCheckBox20.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox20.TabIndex = 2;
            this.metroCheckBox20.Text = "添加一";
            this.metroCheckBox20.UseSelectable = true;
            // 
            // stoppt_userlayer_cb1
            // 
            this.stoppt_userlayer_cb1.AutoSize = true;
            this.stoppt_userlayer_cb1.Location = new System.Drawing.Point(8, 74);
            this.stoppt_userlayer_cb1.Name = "stoppt_userlayer_cb1";
            this.stoppt_userlayer_cb1.Size = new System.Drawing.Size(72, 17);
            this.stoppt_userlayer_cb1.TabIndex = 1;
            this.stoppt_userlayer_cb1.Text = "用户轨迹";
            this.stoppt_userlayer_cb1.UseSelectable = true;
            // 
            // stoppt_processB_gb
            // 
            this.stoppt_processB_gb.BackColor = System.Drawing.SystemColors.Window;
            this.stoppt_processB_gb.Controls.Add(this.stoppt_processbar);
            this.stoppt_processB_gb.Location = new System.Drawing.Point(3, 529);
            this.stoppt_processB_gb.Name = "stoppt_processB_gb";
            this.stoppt_processB_gb.Size = new System.Drawing.Size(934, 46);
            this.stoppt_processB_gb.TabIndex = 16;
            this.stoppt_processB_gb.TabStop = false;
            this.stoppt_processB_gb.Text = "进度";
            // 
            // stoppt_processbar
            // 
            this.stoppt_processbar.Location = new System.Drawing.Point(6, 17);
            this.stoppt_processbar.Name = "stoppt_processbar";
            this.stoppt_processbar.Size = new System.Drawing.Size(821, 23);
            this.stoppt_processbar.TabIndex = 0;
            // 
            // stoppt_Cancel_bt
            // 
            this.stoppt_Cancel_bt.Location = new System.Drawing.Point(462, 580);
            this.stoppt_Cancel_bt.Name = "stoppt_Cancel_bt";
            this.stoppt_Cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.stoppt_Cancel_bt.TabIndex = 14;
            this.stoppt_Cancel_bt.Text = "取消";
            this.stoppt_Cancel_bt.UseVisualStyleBackColor = true;
            // 
            // stoppt_Next_bt
            // 
            this.stoppt_Next_bt.Location = new System.Drawing.Point(370, 580);
            this.stoppt_Next_bt.Name = "stoppt_Next_bt";
            this.stoppt_Next_bt.Size = new System.Drawing.Size(75, 23);
            this.stoppt_Next_bt.TabIndex = 13;
            this.stoppt_Next_bt.Text = "下一步";
            this.stoppt_Next_bt.UseVisualStyleBackColor = true;
            // 
            // stoppt_Back_bt
            // 
            this.stoppt_Back_bt.Location = new System.Drawing.Point(279, 581);
            this.stoppt_Back_bt.Name = "stoppt_Back_bt";
            this.stoppt_Back_bt.Size = new System.Drawing.Size(75, 23);
            this.stoppt_Back_bt.TabIndex = 12;
            this.stoppt_Back_bt.Text = "上一步";
            this.stoppt_Back_bt.UseVisualStyleBackColor = true;
            // 
            // stoppt_pm_gb
            // 
            this.stoppt_pm_gb.BackColor = System.Drawing.SystemColors.Window;
            this.stoppt_pm_gb.Controls.Add(this.stoppt_start_bt);
            this.stoppt_pm_gb.Controls.Add(this.button5);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_pm_tb2);
            this.stoppt_pm_gb.Controls.Add(this.label3);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_pm_tb1);
            this.stoppt_pm_gb.Controls.Add(this.label4);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_input_bt);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_output_bt);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_input_tb);
            this.stoppt_pm_gb.Controls.Add(this.stoppt_output_tb);
            this.stoppt_pm_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stoppt_pm_gb.Location = new System.Drawing.Point(0, 7);
            this.stoppt_pm_gb.Name = "stoppt_pm_gb";
            this.stoppt_pm_gb.Size = new System.Drawing.Size(150, 225);
            this.stoppt_pm_gb.TabIndex = 29;
            this.stoppt_pm_gb.TabStop = false;
            this.stoppt_pm_gb.Text = "路径与参数";
            // 
            // stoppt_start_bt
            // 
            this.stoppt_start_bt.Location = new System.Drawing.Point(6, 180);
            this.stoppt_start_bt.Name = "stoppt_start_bt";
            this.stoppt_start_bt.Size = new System.Drawing.Size(125, 23);
            this.stoppt_start_bt.TabIndex = 39;
            this.stoppt_start_bt.Text = "开始";
            this.stoppt_start_bt.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(19, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "开始";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // stoppt_pm_tb2
            // 
            this.stoppt_pm_tb2.Location = new System.Drawing.Point(53, 137);
            this.stoppt_pm_tb2.Name = "stoppt_pm_tb2";
            this.stoppt_pm_tb2.Size = new System.Drawing.Size(81, 23);
            this.stoppt_pm_tb2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "参数一";
            // 
            // stoppt_pm_tb1
            // 
            this.stoppt_pm_tb1.Location = new System.Drawing.Point(53, 98);
            this.stoppt_pm_tb1.Name = "stoppt_pm_tb1";
            this.stoppt_pm_tb1.Size = new System.Drawing.Size(81, 23);
            this.stoppt_pm_tb1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "参数二";
            // 
            // stoppt_input_bt
            // 
            this.stoppt_input_bt.Location = new System.Drawing.Point(6, 64);
            this.stoppt_input_bt.Name = "stoppt_input_bt";
            this.stoppt_input_bt.Size = new System.Drawing.Size(41, 23);
            this.stoppt_input_bt.TabIndex = 29;
            this.stoppt_input_bt.Text = "输入";
            this.stoppt_input_bt.UseVisualStyleBackColor = true;
            // 
            // stoppt_output_bt
            // 
            this.stoppt_output_bt.Location = new System.Drawing.Point(6, 30);
            this.stoppt_output_bt.Name = "stoppt_output_bt";
            this.stoppt_output_bt.Size = new System.Drawing.Size(41, 23);
            this.stoppt_output_bt.TabIndex = 31;
            this.stoppt_output_bt.Text = "输出";
            this.stoppt_output_bt.UseVisualStyleBackColor = true;
            // 
            // stoppt_input_tb
            // 
            this.stoppt_input_tb.Location = new System.Drawing.Point(53, 64);
            this.stoppt_input_tb.Name = "stoppt_input_tb";
            this.stoppt_input_tb.Size = new System.Drawing.Size(82, 23);
            this.stoppt_input_tb.TabIndex = 30;
            // 
            // stoppt_output_tb
            // 
            this.stoppt_output_tb.Location = new System.Drawing.Point(53, 30);
            this.stoppt_output_tb.Name = "stoppt_output_tb";
            this.stoppt_output_tb.Size = new System.Drawing.Size(82, 23);
            this.stoppt_output_tb.TabIndex = 32;
            // 
            // actTabPage
            // 
            this.actTabPage.Controls.Add(this.activityas_BP_gb);
            this.actTabPage.Controls.Add(this.activityas_layer_gb);
            this.actTabPage.Controls.Add(this.activityas_cancel_bt);
            this.actTabPage.Controls.Add(this.activityas_next_bt);
            this.actTabPage.Controls.Add(this.activityas_back_bt);
            this.actTabPage.Controls.Add(this.groupBox6);
            this.actTabPage.Controls.Add(this.activityas_pm_gb);
            this.actTabPage.HorizontalScrollbar = true;
            this.actTabPage.HorizontalScrollbarBarColor = true;
            this.actTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.actTabPage.HorizontalScrollbarSize = 9;
            this.actTabPage.Location = new System.Drawing.Point(4, 39);
            this.actTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.actTabPage.Name = "actTabPage";
            this.actTabPage.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.actTabPage.Size = new System.Drawing.Size(940, 605);
            this.actTabPage.TabIndex = 2;
            this.actTabPage.Text = "活动分析";
            this.actTabPage.VerticalScrollbar = true;
            this.actTabPage.VerticalScrollbarBarColor = true;
            this.actTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.actTabPage.VerticalScrollbarSize = 10;
            this.actTabPage.Visible = false;
            // 
            // activityas_BP_gb
            // 
            this.activityas_BP_gb.BackColor = System.Drawing.SystemColors.Window;
            this.activityas_BP_gb.Controls.Add(this.activityas_PB);
            this.activityas_BP_gb.Location = new System.Drawing.Point(0, 520);
            this.activityas_BP_gb.Name = "activityas_BP_gb";
            this.activityas_BP_gb.Size = new System.Drawing.Size(799, 54);
            this.activityas_BP_gb.TabIndex = 10;
            this.activityas_BP_gb.TabStop = false;
            this.activityas_BP_gb.Text = "进度";
            // 
            // activityas_PB
            // 
            this.activityas_PB.Location = new System.Drawing.Point(10, 21);
            this.activityas_PB.Name = "activityas_PB";
            this.activityas_PB.Size = new System.Drawing.Size(719, 23);
            this.activityas_PB.TabIndex = 0;
            // 
            // activityas_layer_gb
            // 
            this.activityas_layer_gb.BackColor = System.Drawing.SystemColors.Window;
            this.activityas_layer_gb.Controls.Add(this.activityas_pm_cb2);
            this.activityas_layer_gb.Controls.Add(this.activityas_pm_cb1);
            this.activityas_layer_gb.Location = new System.Drawing.Point(0, 287);
            this.activityas_layer_gb.Name = "activityas_layer_gb";
            this.activityas_layer_gb.Size = new System.Drawing.Size(150, 216);
            this.activityas_layer_gb.TabIndex = 9;
            this.activityas_layer_gb.TabStop = false;
            this.activityas_layer_gb.Text = "可视化参数";
            // 
            // activityas_pm_cb2
            // 
            this.activityas_pm_cb2.AutoSize = true;
            this.activityas_pm_cb2.Location = new System.Drawing.Point(10, 87);
            this.activityas_pm_cb2.Name = "activityas_pm_cb2";
            this.activityas_pm_cb2.Size = new System.Drawing.Size(79, 17);
            this.activityas_pm_cb2.TabIndex = 1;
            this.activityas_pm_cb2.Text = "可选参数2";
            this.activityas_pm_cb2.UseSelectable = true;
            // 
            // activityas_pm_cb1
            // 
            this.activityas_pm_cb1.AutoSize = true;
            this.activityas_pm_cb1.Location = new System.Drawing.Point(10, 40);
            this.activityas_pm_cb1.Name = "activityas_pm_cb1";
            this.activityas_pm_cb1.Size = new System.Drawing.Size(79, 17);
            this.activityas_pm_cb1.TabIndex = 0;
            this.activityas_pm_cb1.Text = "可选参数1";
            this.activityas_pm_cb1.UseSelectable = true;
            // 
            // activityas_cancel_bt
            // 
            this.activityas_cancel_bt.Location = new System.Drawing.Point(478, 582);
            this.activityas_cancel_bt.Name = "activityas_cancel_bt";
            this.activityas_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.activityas_cancel_bt.TabIndex = 7;
            this.activityas_cancel_bt.Text = "取消";
            this.activityas_cancel_bt.UseVisualStyleBackColor = true;
            // 
            // activityas_next_bt
            // 
            this.activityas_next_bt.Location = new System.Drawing.Point(387, 582);
            this.activityas_next_bt.Name = "activityas_next_bt";
            this.activityas_next_bt.Size = new System.Drawing.Size(75, 23);
            this.activityas_next_bt.TabIndex = 6;
            this.activityas_next_bt.Text = "下一步";
            this.activityas_next_bt.UseVisualStyleBackColor = true;
            // 
            // activityas_back_bt
            // 
            this.activityas_back_bt.Location = new System.Drawing.Point(294, 582);
            this.activityas_back_bt.Name = "activityas_back_bt";
            this.activityas_back_bt.Size = new System.Drawing.Size(75, 23);
            this.activityas_back_bt.TabIndex = 5;
            this.activityas_back_bt.Text = "上一步";
            this.activityas_back_bt.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(160, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(777, 496);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "统计与可视化";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MetroFramework.Demo.Properties.Resources.搜狗截图20161024094052;
            this.pictureBox3.Location = new System.Drawing.Point(6, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(765, 468);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // activityas_pm_gb
            // 
            this.activityas_pm_gb.BackColor = System.Drawing.SystemColors.Window;
            this.activityas_pm_gb.Controls.Add(this.activityas_pm_cbb);
            this.activityas_pm_gb.Controls.Add(this.activityas_pm_tb2);
            this.activityas_pm_gb.Controls.Add(this.activityas_start_bt);
            this.activityas_pm_gb.Controls.Add(this.metroLabel1);
            this.activityas_pm_gb.Controls.Add(this.activityas_pm_tb);
            this.activityas_pm_gb.Controls.Add(this.metroLabel6);
            this.activityas_pm_gb.Controls.Add(this.metroLabel7);
            this.activityas_pm_gb.Controls.Add(this.activityas_pm_tb1);
            this.activityas_pm_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.activityas_pm_gb.Location = new System.Drawing.Point(0, 7);
            this.activityas_pm_gb.Name = "activityas_pm_gb";
            this.activityas_pm_gb.Size = new System.Drawing.Size(150, 259);
            this.activityas_pm_gb.TabIndex = 2;
            this.activityas_pm_gb.TabStop = false;
            this.activityas_pm_gb.Text = "参数选择";
            // 
            // activityas_pm_cbb
            // 
            this.activityas_pm_cbb.FormattingEnabled = true;
            this.activityas_pm_cbb.Items.AddRange(new object[] {
            "居家工作分析",
            "社会活动分析"});
            this.activityas_pm_cbb.Location = new System.Drawing.Point(10, 27);
            this.activityas_pm_cbb.Name = "activityas_pm_cbb";
            this.activityas_pm_cbb.Size = new System.Drawing.Size(134, 25);
            this.activityas_pm_cbb.TabIndex = 0;
            this.activityas_pm_cbb.Text = "居家工作分析";
            // 
            // activityas_pm_tb2
            // 
            this.activityas_pm_tb2.Location = new System.Drawing.Point(67, 106);
            this.activityas_pm_tb2.Name = "activityas_pm_tb2";
            this.activityas_pm_tb2.Size = new System.Drawing.Size(77, 23);
            this.activityas_pm_tb2.TabIndex = 4;
            // 
            // activityas_start_bt
            // 
            this.activityas_start_bt.Location = new System.Drawing.Point(10, 192);
            this.activityas_start_bt.Name = "activityas_start_bt";
            this.activityas_start_bt.Size = new System.Drawing.Size(134, 23);
            this.activityas_start_bt.TabIndex = 9;
            this.activityas_start_bt.Text = "开始";
            this.activityas_start_bt.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "参数一";
            // 
            // activityas_pm_tb
            // 
            this.activityas_pm_tb.Location = new System.Drawing.Point(67, 147);
            this.activityas_pm_tb.Name = "activityas_pm_tb";
            this.activityas_pm_tb.Size = new System.Drawing.Size(77, 23);
            this.activityas_pm_tb.TabIndex = 6;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 109);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 20);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "参数二";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 150);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 20);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "参数三";
            // 
            // activityas_pm_tb1
            // 
            this.activityas_pm_tb1.Location = new System.Drawing.Point(67, 67);
            this.activityas_pm_tb1.Name = "activityas_pm_tb1";
            this.activityas_pm_tb1.Size = new System.Drawing.Size(77, 23);
            this.activityas_pm_tb1.TabIndex = 3;
            // 
            // travelTabPage
            // 
            this.travelTabPage.Controls.Add(this.tripas_PB_gb);
            this.travelTabPage.Controls.Add(this.tripas_layer_gb);
            this.travelTabPage.Controls.Add(this.tripas_cancel_bt);
            this.travelTabPage.Controls.Add(this.tripas_back_bt);
            this.travelTabPage.Controls.Add(this.groupBox8);
            this.travelTabPage.Controls.Add(this.tripas_pm_gb);
            this.travelTabPage.HorizontalScrollbarBarColor = true;
            this.travelTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.travelTabPage.HorizontalScrollbarSize = 9;
            this.travelTabPage.Location = new System.Drawing.Point(4, 39);
            this.travelTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.travelTabPage.Name = "travelTabPage";
            this.travelTabPage.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.travelTabPage.Size = new System.Drawing.Size(940, 605);
            this.travelTabPage.TabIndex = 3;
            this.travelTabPage.Text = "出行分析";
            this.travelTabPage.VerticalScrollbarBarColor = true;
            this.travelTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.travelTabPage.VerticalScrollbarSize = 10;
            this.travelTabPage.Visible = false;
            // 
            // tripas_PB_gb
            // 
            this.tripas_PB_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tripas_PB_gb.Controls.Add(this.tripas_PB);
            this.tripas_PB_gb.Location = new System.Drawing.Point(0, 512);
            this.tripas_PB_gb.Name = "tripas_PB_gb";
            this.tripas_PB_gb.Size = new System.Drawing.Size(799, 46);
            this.tripas_PB_gb.TabIndex = 9;
            this.tripas_PB_gb.TabStop = false;
            this.tripas_PB_gb.Text = "进度";
            // 
            // tripas_PB
            // 
            this.tripas_PB.Location = new System.Drawing.Point(7, 16);
            this.tripas_PB.Name = "tripas_PB";
            this.tripas_PB.Size = new System.Drawing.Size(724, 23);
            this.tripas_PB.TabIndex = 0;
            // 
            // tripas_layer_gb
            // 
            this.tripas_layer_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tripas_layer_gb.Controls.Add(this.metroCheckBox13);
            this.tripas_layer_gb.Controls.Add(this.metroCheckBox12);
            this.tripas_layer_gb.Location = new System.Drawing.Point(0, 251);
            this.tripas_layer_gb.Name = "tripas_layer_gb";
            this.tripas_layer_gb.Size = new System.Drawing.Size(150, 255);
            this.tripas_layer_gb.TabIndex = 8;
            this.tripas_layer_gb.TabStop = false;
            this.tripas_layer_gb.Text = "可视化参数";
            // 
            // metroCheckBox13
            // 
            this.metroCheckBox13.AutoSize = true;
            this.metroCheckBox13.Location = new System.Drawing.Point(7, 104);
            this.metroCheckBox13.Name = "metroCheckBox13";
            this.metroCheckBox13.Size = new System.Drawing.Size(79, 17);
            this.metroCheckBox13.TabIndex = 1;
            this.metroCheckBox13.Text = "可选参数2";
            this.metroCheckBox13.UseSelectable = true;
            // 
            // metroCheckBox12
            // 
            this.metroCheckBox12.AutoSize = true;
            this.metroCheckBox12.Location = new System.Drawing.Point(7, 44);
            this.metroCheckBox12.Name = "metroCheckBox12";
            this.metroCheckBox12.Size = new System.Drawing.Size(79, 17);
            this.metroCheckBox12.TabIndex = 0;
            this.metroCheckBox12.Text = "可选参数1";
            this.metroCheckBox12.UseSelectable = true;
            // 
            // tripas_cancel_bt
            // 
            this.tripas_cancel_bt.Location = new System.Drawing.Point(435, 575);
            this.tripas_cancel_bt.Name = "tripas_cancel_bt";
            this.tripas_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.tripas_cancel_bt.TabIndex = 7;
            this.tripas_cancel_bt.Text = "取消";
            this.tripas_cancel_bt.UseVisualStyleBackColor = true;
            // 
            // tripas_back_bt
            // 
            this.tripas_back_bt.Location = new System.Drawing.Point(264, 575);
            this.tripas_back_bt.Name = "tripas_back_bt";
            this.tripas_back_bt.Size = new System.Drawing.Size(75, 23);
            this.tripas_back_bt.TabIndex = 5;
            this.tripas_back_bt.Text = "上一步";
            this.tripas_back_bt.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox8.Controls.Add(this.pictureBox4);
            this.groupBox8.Controls.Add(this.metroLabel13);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(160, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(777, 492);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "统计与可视化";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MetroFramework.Demo.Properties.Resources.搜狗截图20161024094052;
            this.pictureBox4.Location = new System.Drawing.Point(16, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(755, 464);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(276, 17);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(51, 20);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "可视化";
            // 
            // tripas_pm_gb
            // 
            this.tripas_pm_gb.BackColor = System.Drawing.SystemColors.Window;
            this.tripas_pm_gb.Controls.Add(this.tripas_start_bt);
            this.tripas_pm_gb.Controls.Add(this.tripas_pm_tb3);
            this.tripas_pm_gb.Controls.Add(this.tripas_pm_tb2);
            this.tripas_pm_gb.Controls.Add(this.metroLabel12);
            this.tripas_pm_gb.Controls.Add(this.metroLabel11);
            this.tripas_pm_gb.Controls.Add(this.tripas_pm_tb1);
            this.tripas_pm_gb.Controls.Add(this.metroLabel10);
            this.tripas_pm_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tripas_pm_gb.Location = new System.Drawing.Point(0, 7);
            this.tripas_pm_gb.Name = "tripas_pm_gb";
            this.tripas_pm_gb.Size = new System.Drawing.Size(150, 225);
            this.tripas_pm_gb.TabIndex = 2;
            this.tripas_pm_gb.TabStop = false;
            this.tripas_pm_gb.Text = "参数选择";
            // 
            // tripas_start_bt
            // 
            this.tripas_start_bt.Location = new System.Drawing.Point(7, 164);
            this.tripas_start_bt.Name = "tripas_start_bt";
            this.tripas_start_bt.Size = new System.Drawing.Size(133, 23);
            this.tripas_start_bt.TabIndex = 6;
            this.tripas_start_bt.Text = "开始";
            this.tripas_start_bt.UseVisualStyleBackColor = true;
            // 
            // tripas_pm_tb3
            // 
            this.tripas_pm_tb3.Location = new System.Drawing.Point(70, 117);
            this.tripas_pm_tb3.Name = "tripas_pm_tb3";
            this.tripas_pm_tb3.Size = new System.Drawing.Size(70, 23);
            this.tripas_pm_tb3.TabIndex = 5;
            // 
            // tripas_pm_tb2
            // 
            this.tripas_pm_tb2.Location = new System.Drawing.Point(70, 74);
            this.tripas_pm_tb2.Name = "tripas_pm_tb2";
            this.tripas_pm_tb2.Size = new System.Drawing.Size(70, 23);
            this.tripas_pm_tb2.TabIndex = 4;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(5, 120);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(51, 20);
            this.metroLabel12.TabIndex = 3;
            this.metroLabel12.Text = "参数三";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 77);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 20);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "参数二";
            // 
            // tripas_pm_tb1
            // 
            this.tripas_pm_tb1.Location = new System.Drawing.Point(70, 32);
            this.tripas_pm_tb1.Name = "tripas_pm_tb1";
            this.tripas_pm_tb1.Size = new System.Drawing.Size(70, 23);
            this.tripas_pm_tb1.TabIndex = 1;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(7, 35);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 20);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "参数一";
            // 
            // batchTabPage
            // 
            this.batchTabPage.Controls.Add(this.batch_layer_gb);
            this.batchTabPage.Controls.Add(this.batch_PB_gb);
            this.batchTabPage.Controls.Add(this.batch_stop_bt);
            this.batchTabPage.Controls.Add(this.batch_cancel_bt);
            this.batchTabPage.Controls.Add(this.groupBox10);
            this.batchTabPage.Controls.Add(this.batch_pm_gb);
            this.batchTabPage.HorizontalScrollbarBarColor = true;
            this.batchTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.batchTabPage.HorizontalScrollbarSize = 9;
            this.batchTabPage.Location = new System.Drawing.Point(4, 39);
            this.batchTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batchTabPage.Name = "batchTabPage";
            this.batchTabPage.Size = new System.Drawing.Size(940, 605);
            this.batchTabPage.TabIndex = 5;
            this.batchTabPage.Text = "批量处理";
            this.batchTabPage.VerticalScrollbarBarColor = true;
            this.batchTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.batchTabPage.VerticalScrollbarSize = 10;
            this.batchTabPage.Visible = false;
            // 
            // batch_layer_gb
            // 
            this.batch_layer_gb.BackColor = System.Drawing.SystemColors.Window;
            this.batch_layer_gb.Controls.Add(this.batch_layer_cb2);
            this.batch_layer_gb.Controls.Add(this.batch_layer_cb1);
            this.batch_layer_gb.Location = new System.Drawing.Point(0, 248);
            this.batch_layer_gb.Name = "batch_layer_gb";
            this.batch_layer_gb.Size = new System.Drawing.Size(150, 274);
            this.batch_layer_gb.TabIndex = 10;
            this.batch_layer_gb.TabStop = false;
            this.batch_layer_gb.Text = "可视化参数";
            // 
            // batch_layer_cb2
            // 
            this.batch_layer_cb2.AutoSize = true;
            this.batch_layer_cb2.Location = new System.Drawing.Point(9, 89);
            this.batch_layer_cb2.Name = "batch_layer_cb2";
            this.batch_layer_cb2.Size = new System.Drawing.Size(79, 17);
            this.batch_layer_cb2.TabIndex = 1;
            this.batch_layer_cb2.Text = "可选参数2";
            this.batch_layer_cb2.UseSelectable = true;
            // 
            // batch_layer_cb1
            // 
            this.batch_layer_cb1.AutoSize = true;
            this.batch_layer_cb1.Location = new System.Drawing.Point(9, 49);
            this.batch_layer_cb1.Name = "batch_layer_cb1";
            this.batch_layer_cb1.Size = new System.Drawing.Size(79, 17);
            this.batch_layer_cb1.TabIndex = 0;
            this.batch_layer_cb1.Text = "可选参数1";
            this.batch_layer_cb1.UseSelectable = true;
            // 
            // batch_PB_gb
            // 
            this.batch_PB_gb.BackColor = System.Drawing.SystemColors.Window;
            this.batch_PB_gb.Controls.Add(this.batch_PB);
            this.batch_PB_gb.Location = new System.Drawing.Point(0, 528);
            this.batch_PB_gb.Name = "batch_PB_gb";
            this.batch_PB_gb.Size = new System.Drawing.Size(937, 46);
            this.batch_PB_gb.TabIndex = 9;
            this.batch_PB_gb.TabStop = false;
            this.batch_PB_gb.Text = "进度";
            // 
            // batch_PB
            // 
            this.batch_PB.Location = new System.Drawing.Point(9, 17);
            this.batch_PB.Name = "batch_PB";
            this.batch_PB.Size = new System.Drawing.Size(908, 23);
            this.batch_PB.TabIndex = 0;
            this.batch_PB.Value = 88;
            // 
            // batch_stop_bt
            // 
            this.batch_stop_bt.Location = new System.Drawing.Point(314, 580);
            this.batch_stop_bt.Name = "batch_stop_bt";
            this.batch_stop_bt.Size = new System.Drawing.Size(75, 23);
            this.batch_stop_bt.TabIndex = 8;
            this.batch_stop_bt.Text = "暂停";
            this.batch_stop_bt.UseVisualStyleBackColor = true;
            // 
            // batch_cancel_bt
            // 
            this.batch_cancel_bt.Location = new System.Drawing.Point(409, 580);
            this.batch_cancel_bt.Name = "batch_cancel_bt";
            this.batch_cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.batch_cancel_bt.TabIndex = 4;
            this.batch_cancel_bt.Text = "取消";
            this.batch_cancel_bt.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.Location = new System.Drawing.Point(160, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(777, 506);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "统计";
            // 
            // batch_pm_gb
            // 
            this.batch_pm_gb.BackColor = System.Drawing.SystemColors.Window;
            this.batch_pm_gb.Controls.Add(this.button24);
            this.batch_pm_gb.Controls.Add(this.batch_tripas_cb);
            this.batch_pm_gb.Controls.Add(this.batch_activityas_cb);
            this.batch_pm_gb.Controls.Add(this.batch_stoppt_cb);
            this.batch_pm_gb.Controls.Add(this.batch_tra_cb);
            this.batch_pm_gb.Controls.Add(this.batch_output_tb);
            this.batch_pm_gb.Controls.Add(this.batch_input_tb);
            this.batch_pm_gb.Controls.Add(this.batch_output_bt);
            this.batch_pm_gb.Controls.Add(this.batch_input_bt);
            this.batch_pm_gb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.batch_pm_gb.Location = new System.Drawing.Point(0, 7);
            this.batch_pm_gb.Name = "batch_pm_gb";
            this.batch_pm_gb.Size = new System.Drawing.Size(150, 225);
            this.batch_pm_gb.TabIndex = 2;
            this.batch_pm_gb.TabStop = false;
            this.batch_pm_gb.Text = "路径与参数";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(18, 241);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 8;
            this.button24.Text = "开始";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // batch_tripas_cb
            // 
            this.batch_tripas_cb.AutoSize = true;
            this.batch_tripas_cb.Location = new System.Drawing.Point(9, 199);
            this.batch_tripas_cb.Name = "batch_tripas_cb";
            this.batch_tripas_cb.Size = new System.Drawing.Size(72, 17);
            this.batch_tripas_cb.TabIndex = 7;
            this.batch_tripas_cb.Text = "出行分析";
            this.batch_tripas_cb.UseSelectable = true;
            // 
            // batch_activityas_cb
            // 
            this.batch_activityas_cb.AutoSize = true;
            this.batch_activityas_cb.Location = new System.Drawing.Point(9, 171);
            this.batch_activityas_cb.Name = "batch_activityas_cb";
            this.batch_activityas_cb.Size = new System.Drawing.Size(72, 17);
            this.batch_activityas_cb.TabIndex = 6;
            this.batch_activityas_cb.Text = "活动分析";
            this.batch_activityas_cb.UseSelectable = true;
            // 
            // batch_stoppt_cb
            // 
            this.batch_stoppt_cb.AutoSize = true;
            this.batch_stoppt_cb.Location = new System.Drawing.Point(9, 142);
            this.batch_stoppt_cb.Name = "batch_stoppt_cb";
            this.batch_stoppt_cb.Size = new System.Drawing.Size(84, 17);
            this.batch_stoppt_cb.TabIndex = 5;
            this.batch_stoppt_cb.Text = "停留点探测";
            this.batch_stoppt_cb.UseSelectable = true;
            // 
            // batch_tra_cb
            // 
            this.batch_tra_cb.AutoSize = true;
            this.batch_tra_cb.Location = new System.Drawing.Point(9, 113);
            this.batch_tra_cb.Name = "batch_tra_cb";
            this.batch_tra_cb.Size = new System.Drawing.Size(72, 17);
            this.batch_tra_cb.TabIndex = 4;
            this.batch_tra_cb.Text = "轨迹生成";
            this.batch_tra_cb.UseSelectable = true;
            // 
            // batch_output_tb
            // 
            this.batch_output_tb.Location = new System.Drawing.Point(58, 69);
            this.batch_output_tb.Name = "batch_output_tb";
            this.batch_output_tb.Size = new System.Drawing.Size(86, 23);
            this.batch_output_tb.TabIndex = 3;
            // 
            // batch_input_tb
            // 
            this.batch_input_tb.Location = new System.Drawing.Point(58, 31);
            this.batch_input_tb.Name = "batch_input_tb";
            this.batch_input_tb.Size = new System.Drawing.Size(86, 23);
            this.batch_input_tb.TabIndex = 2;
            // 
            // batch_output_bt
            // 
            this.batch_output_bt.Location = new System.Drawing.Point(6, 68);
            this.batch_output_bt.Name = "batch_output_bt";
            this.batch_output_bt.Size = new System.Drawing.Size(46, 23);
            this.batch_output_bt.TabIndex = 1;
            this.batch_output_bt.Text = "输出";
            this.batch_output_bt.UseVisualStyleBackColor = true;
            // 
            // batch_input_bt
            // 
            this.batch_input_bt.Location = new System.Drawing.Point(6, 31);
            this.batch_input_bt.Name = "batch_input_bt";
            this.batch_input_bt.Size = new System.Drawing.Size(46, 23);
            this.batch_input_bt.TabIndex = 0;
            this.batch_input_bt.Text = "输入";
            this.batch_input_bt.UseVisualStyleBackColor = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroProgressBar6
            // 
            this.metroProgressBar6.Location = new System.Drawing.Point(6, 17);
            this.metroProgressBar6.Name = "metroProgressBar6";
            this.metroProgressBar6.Size = new System.Drawing.Size(670, 23);
            this.metroProgressBar6.TabIndex = 0;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(69, 40);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(82, 21);
            this.textBox20.TabIndex = 32;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(69, 89);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(82, 21);
            this.textBox19.TabIndex = 30;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(6, 40);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(54, 23);
            this.button26.TabIndex = 31;
            this.button26.Text = "输出";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(6, 89);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(54, 23);
            this.button25.TabIndex = 29;
            this.button25.Text = "输入";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 37;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(69, 146);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(82, 21);
            this.textBox18.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 35;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(69, 189);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(82, 21);
            this.textBox17.TabIndex = 38;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button23.Location = new System.Drawing.Point(19, 250);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(132, 23);
            this.button23.TabIndex = 38;
            this.button23.Text = "开始";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox27
            // 
            this.metroCheckBox27.AutoSize = true;
            this.metroCheckBox27.Location = new System.Drawing.Point(8, 74);
            this.metroCheckBox27.Name = "metroCheckBox27";
            this.metroCheckBox27.Size = new System.Drawing.Size(72, 17);
            this.metroCheckBox27.TabIndex = 1;
            this.metroCheckBox27.Text = "用户轨迹";
            this.metroCheckBox27.UseSelectable = true;
            // 
            // metroCheckBox26
            // 
            this.metroCheckBox26.AutoSize = true;
            this.metroCheckBox26.Location = new System.Drawing.Point(8, 111);
            this.metroCheckBox26.Name = "metroCheckBox26";
            this.metroCheckBox26.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox26.TabIndex = 2;
            this.metroCheckBox26.Text = "添加一";
            this.metroCheckBox26.UseSelectable = true;
            // 
            // metroCheckBox25
            // 
            this.metroCheckBox25.AutoSize = true;
            this.metroCheckBox25.Location = new System.Drawing.Point(8, 36);
            this.metroCheckBox25.Name = "metroCheckBox25";
            this.metroCheckBox25.Size = new System.Drawing.Size(48, 17);
            this.metroCheckBox25.TabIndex = 3;
            this.metroCheckBox25.Text = "底图";
            this.metroCheckBox25.UseSelectable = true;
            // 
            // metroCheckBox24
            // 
            this.metroCheckBox24.AutoSize = true;
            this.metroCheckBox24.Location = new System.Drawing.Point(8, 153);
            this.metroCheckBox24.Name = "metroCheckBox24";
            this.metroCheckBox24.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox24.TabIndex = 4;
            this.metroCheckBox24.Text = "添加二";
            this.metroCheckBox24.UseSelectable = true;
            // 
            // metroCheckBox23
            // 
            this.metroCheckBox23.AutoSize = true;
            this.metroCheckBox23.Location = new System.Drawing.Point(8, 191);
            this.metroCheckBox23.Name = "metroCheckBox23";
            this.metroCheckBox23.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox23.TabIndex = 5;
            this.metroCheckBox23.Text = "添加三";
            this.metroCheckBox23.UseSelectable = true;
            // 
            // metroCheckBox22
            // 
            this.metroCheckBox22.AutoSize = true;
            this.metroCheckBox22.Location = new System.Drawing.Point(8, 229);
            this.metroCheckBox22.Name = "metroCheckBox22";
            this.metroCheckBox22.Size = new System.Drawing.Size(60, 17);
            this.metroCheckBox22.TabIndex = 6;
            this.metroCheckBox22.Text = "添加四";
            this.metroCheckBox22.UseSelectable = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(748, 477);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "统计图";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(748, 477);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "地图";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // mapBox2
            // 
            this.mapBox2.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapBox2.FineZoomFactor = 10D;
            this.mapBox2.Location = new System.Drawing.Point(6, -2);
            this.mapBox2.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mapBox2.Name = "mapBox2";
            this.mapBox2.QueryGrowFactor = 5F;
            this.mapBox2.QueryLayerIndex = 0;
            this.mapBox2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox2.ShowProgressUpdate = false;
            this.mapBox2.Size = new System.Drawing.Size(742, 473);
            this.mapBox2.TabIndex = 0;
            this.mapBox2.WheelZoomMagnitude = -2D;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除该图层ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(137, 26);
            // 
            // 删除该图层ToolStripMenuItem
            // 
            this.删除该图层ToolStripMenuItem.Name = "删除该图层ToolStripMenuItem";
            this.删除该图层ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除该图层ToolStripMenuItem.Text = "删除该图层";
            this.删除该图层ToolStripMenuItem.Click += new System.EventHandler(this.删除该图层ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(225, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(979, 705);
            this.Controls.Add(this.FormTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(850, 705);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StyleManager = this.metroStyleManager;
            this.Text = "DATA ANALYSIS TOOL";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormTabControl.ResumeLayout(false);
            this.traTabPage.ResumeLayout(false);
            this.tra_tc.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tra_Progressbar_gb.ResumeLayout(false);
            this.tra_Progressbar_gb.PerformLayout();
            this.tra_layer_gb.ResumeLayout(false);
            this.tra_layer_gb.PerformLayout();
            this.tra_parameter_gb.ResumeLayout(false);
            this.tra_parameter_gb.PerformLayout();
            this.stopptTabPage.ResumeLayout(false);
            this.stoppttc.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.stoppt_layer_gb.ResumeLayout(false);
            this.stoppt_layer_gb.PerformLayout();
            this.stoppt_processB_gb.ResumeLayout(false);
            this.stoppt_pm_gb.ResumeLayout(false);
            this.stoppt_pm_gb.PerformLayout();
            this.actTabPage.ResumeLayout(false);
            this.activityas_BP_gb.ResumeLayout(false);
            this.activityas_layer_gb.ResumeLayout(false);
            this.activityas_layer_gb.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.activityas_pm_gb.ResumeLayout(false);
            this.activityas_pm_gb.PerformLayout();
            this.travelTabPage.ResumeLayout(false);
            this.tripas_PB_gb.ResumeLayout(false);
            this.tripas_layer_gb.ResumeLayout(false);
            this.tripas_layer_gb.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tripas_pm_gb.ResumeLayout(false);
            this.tripas_pm_gb.PerformLayout();
            this.batchTabPage.ResumeLayout(false);
            this.batch_layer_gb.ResumeLayout(false);
            this.batch_layer_gb.PerformLayout();
            this.batch_PB_gb.ResumeLayout(false);
            this.batch_pm_gb.ResumeLayout(false);
            this.batch_pm_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroTabControl FormTabControl;
        private Components.MetroStyleManager metroStyleManager;
        private Controls.MetroTabPage stopptTabPage;
        private Controls.MetroTabPage actTabPage;
        private Controls.MetroTabPage travelTabPage;
        private Components.MetroStyleExtender metroStyleExtender;
        private Controls.MetroTabPage batchTabPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button stoppt_Cancel_bt;
        private System.Windows.Forms.Button stoppt_Next_bt;
        private System.Windows.Forms.Button stoppt_Back_bt;
        private System.Windows.Forms.GroupBox activityas_pm_gb;
        private System.Windows.Forms.ComboBox activityas_pm_cbb;
        private System.Windows.Forms.Button activityas_cancel_bt;
        private System.Windows.Forms.Button activityas_next_bt;
        private System.Windows.Forms.Button activityas_back_bt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox activityas_pm_tb;
        private MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox activityas_pm_tb2;
        private MetroLabel metroLabel6;
        private System.Windows.Forms.Button tripas_cancel_bt;
        private System.Windows.Forms.Button tripas_back_bt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroLabel metroLabel13;
        private System.Windows.Forms.GroupBox tripas_pm_gb;
        private System.Windows.Forms.TextBox tripas_pm_tb3;
        private System.Windows.Forms.TextBox tripas_pm_tb2;
        private MetroLabel metroLabel12;
        private MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox tripas_pm_tb1;
        private MetroLabel metroLabel10;
        private System.Windows.Forms.Button batch_stop_bt;
        private System.Windows.Forms.Button batch_cancel_bt;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox batch_pm_gb;
        private MetroCheckBox batch_tripas_cb;
        private MetroCheckBox batch_activityas_cb;
        private MetroCheckBox batch_stoppt_cb;
        private MetroCheckBox batch_tra_cb;
        private System.Windows.Forms.TextBox batch_output_tb;
        private System.Windows.Forms.TextBox batch_input_tb;
        private System.Windows.Forms.Button batch_output_bt;
        private System.Windows.Forms.Button batch_input_bt;
        private System.Windows.Forms.GroupBox stoppt_processB_gb;
        private MetroProgressBar stoppt_processbar;
        private System.Windows.Forms.GroupBox activityas_BP_gb;
        private MetroProgressBar activityas_PB;
        private System.Windows.Forms.GroupBox activityas_layer_gb;
        private System.Windows.Forms.Button activityas_start_bt;
        private System.Windows.Forms.GroupBox tripas_PB_gb;
        private MetroProgressBar tripas_PB;
        private System.Windows.Forms.GroupBox tripas_layer_gb;
        private System.Windows.Forms.Button tripas_start_bt;
        private System.Windows.Forms.GroupBox batch_layer_gb;
        private System.Windows.Forms.GroupBox batch_PB_gb;
        private MetroProgressBar batch_PB;
        private System.Windows.Forms.Button button24;
        private MetroCheckBox activityas_pm_cb2;
        private MetroCheckBox activityas_pm_cb1;
        private MetroCheckBox metroCheckBox13;
        private MetroCheckBox metroCheckBox12;
        private MetroCheckBox batch_layer_cb2;
        private MetroCheckBox batch_layer_cb1;
        private MetroTabPage traTabPage;
        private System.Windows.Forms.Button tra_output_bt;
        private System.Windows.Forms.TextBox tra_output_tb;
        private System.Windows.Forms.TextBox tra_pm_tb1;
        private System.Windows.Forms.Label trapala2;
        private System.Windows.Forms.TabControl tra_tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label trapalb1;
        private SharpMap.Forms.MapBox tramap;
        private System.Windows.Forms.TextBox tra_pm_tb2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox tra_Progressbar_gb;
        private MetroLabel metroLabel18;
        private MetroProgressBar tra_Progressbar;
        private System.Windows.Forms.GroupBox tra_layer_gb;
        private MetroCheckBox tra_userlayer_cb3;
        private MetroCheckBox tra_userlayer_cb2;
        private MetroCheckBox tra_baselayer_cb;
        private MetroCheckBox tra_userlayer_cb1;
        private MetroCheckBox tra_Result_cb;
        private System.Windows.Forms.Button tra_next_bt;
        private System.Windows.Forms.GroupBox tra_parameter_gb;
        private System.Windows.Forms.Button tra_input_bt;
        private System.Windows.Forms.TextBox tra_input_tb;
        private System.Windows.Forms.Button tra_cancel_bt;
        private MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox activityas_pm_tb1;
        private System.Windows.Forms.TabControl stoppttc;
        private System.Windows.Forms.TabPage tabPage3;
        private SharpMap.Forms.MapBox stoppt_map;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox stoppt_layer_gb;
        private MetroCheckBox metroCheckBox7;
        private MetroCheckBox metroCheckBox8;
        private MetroCheckBox metroCheckBox9;
        private MetroCheckBox stoppt_baselayer_cb;
        private MetroCheckBox metroCheckBox20;
        private MetroCheckBox stoppt_userlayer_cb1;
        private System.Windows.Forms.GroupBox stoppt_pm_gb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox stoppt_pm_tb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stoppt_pm_tb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stoppt_input_bt;
        private System.Windows.Forms.Button stoppt_output_bt;
        private System.Windows.Forms.TextBox stoppt_input_tb;
        private System.Windows.Forms.TextBox stoppt_output_tb;
        private MetroProgressBar metroProgressBar6;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button23;
        private MetroCheckBox metroCheckBox27;
        private MetroCheckBox metroCheckBox26;
        private MetroCheckBox metroCheckBox25;
        private MetroCheckBox metroCheckBox24;
        private MetroCheckBox metroCheckBox23;
        private MetroCheckBox metroCheckBox22;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private SharpMap.Forms.MapBox mapBox2;
        private System.Windows.Forms.Button tra_addlayer_bt;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 删除该图层ToolStripMenuItem;
        private System.Windows.Forms.Button tra_start_bt;
        private System.Windows.Forms.Button stoppt_start_bt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

