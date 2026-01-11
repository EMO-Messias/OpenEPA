namespace OpenEPAYT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            BTOpen = new ToolStripButton();
            MapViewer = new DotSpatial.Controls.Map();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            MapLayers = new DotSpatial.Controls.Legend();
            groupBox1 = new GroupBox();
            statusStrip1 = new StatusStrip();
            LBCoordinates = new ToolStripStatusLabel();
            AppManager = new DotSpatial.Controls.AppManager();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, BTOpen });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1049, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // BTOpen
            // 
            BTOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTOpen.Image = (Image)resources.GetObject("BTOpen.Image");
            BTOpen.ImageScaling = ToolStripItemImageScaling.None;
            BTOpen.ImageTransparentColor = Color.Magenta;
            BTOpen.Name = "BTOpen";
            BTOpen.Size = new Size(28, 28);
            BTOpen.Text = "toolStripButton2";
            BTOpen.Click += BTOpen_Click;
            // 
            // MapViewer
            // 
            MapViewer.AllowDrop = true;
            MapViewer.BackColor = Color.White;
            MapViewer.CollisionDetection = false;
            MapViewer.Dock = DockStyle.Fill;
            MapViewer.ExtendBuffer = false;
            MapViewer.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            MapViewer.IsBusy = false;
            MapViewer.IsZoomedToMaxExtent = false;
            MapViewer.Legend = null;
            MapViewer.Location = new Point(3, 19);
            MapViewer.Name = "MapViewer";
            MapViewer.ProgressHandler = null;
            MapViewer.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            MapViewer.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            MapViewer.RedrawLayersWhileResizing = false;
            MapViewer.SelectionEnabled = true;
            MapViewer.Size = new Size(795, 589);
            MapViewer.TabIndex = 1;
            MapViewer.ZoomOutFartherThanMaxExtent = false;
            MapViewer.GeoMouseMove += MapViewer_GeoMouseMove;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1049, 645);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1041, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Desenho";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1035, 611);
            splitContainer1.SplitterDistance = 230;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MapLayers);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 611);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // MapLayers
            // 
            MapLayers.BackColor = Color.White;
            MapLayers.ControlRectangle = new Rectangle(0, 0, 224, 589);
            MapLayers.Dock = DockStyle.Fill;
            MapLayers.DocumentRectangle = new Rectangle(0, 0, 187, 428);
            MapLayers.HorizontalScrollEnabled = true;
            MapLayers.Indentation = 30;
            MapLayers.IsInitialized = false;
            MapLayers.Location = new Point(3, 19);
            MapLayers.MinimumSize = new Size(5, 5);
            MapLayers.Name = "MapLayers";
            MapLayers.ProgressHandler = null;
            MapLayers.ResetOnResize = false;
            MapLayers.SelectionFontColor = Color.Black;
            MapLayers.SelectionHighlight = Color.FromArgb(215, 238, 252);
            MapLayers.Size = new Size(224, 589);
            MapLayers.TabIndex = 0;
            MapLayers.Text = "legend1";
            MapLayers.UseLegendForSelection = true;
            MapLayers.VerticalScrollEnabled = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusStrip1);
            groupBox1.Controls.Add(MapViewer);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 611);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LBCoordinates });
            statusStrip1.Location = new Point(3, 586);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(795, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // LBCoordinates
            // 
            LBCoordinates.Name = "LBCoordinates";
            LBCoordinates.Size = new Size(12, 17);
            LBCoordinates.Text = "-";
            // 
            // AppManager
            // 
            AppManager.Directories = (List<string>)resources.GetObject("AppManager.Directories");
            AppManager.DockManager = null;
            AppManager.HeaderControl = null;
            AppManager.Legend = MapLayers;
            AppManager.Map = MapViewer;
            AppManager.ProgressHandler = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 676);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "OpenEPA";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton BTOpen;
        private DotSpatial.Controls.Map MapViewer;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LBCoordinates;
        private DotSpatial.Controls.Legend MapLayers;
        private DotSpatial.Controls.AppManager AppManager;
    }
}
