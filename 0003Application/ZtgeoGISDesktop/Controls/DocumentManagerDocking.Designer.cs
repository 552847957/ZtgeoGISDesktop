﻿namespace ZtgeoGISDesktop.Controls
{
    partial class DocumentManagerDocking
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.ResourceContainer = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.resourcePanel1 = new ZtgeoGISDesktop.Resources.ResourcePanel();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.LayersDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.PropertiesDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.ResourceContainer.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.LayersDockPanel.SuspendLayout();
            this.PropertiesDockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController1;
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.barManager1;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.AppearancesDocking.PanelCaption.BackColor = System.Drawing.Color.Transparent;
            this.barAndDockingController1.AppearancesDocking.PanelCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.barAndDockingController1.AppearancesDocking.PanelCaption.Font = new System.Drawing.Font("黑体", 8F);
            this.barAndDockingController1.AppearancesDocking.PanelCaption.ForeColor = System.Drawing.Color.Gray;
            this.barAndDockingController1.AppearancesDocking.PanelCaption.Options.UseBackColor = true;
            this.barAndDockingController1.AppearancesDocking.PanelCaption.Options.UseFont = true;
            this.barAndDockingController1.AppearancesDocking.PanelCaption.Options.UseForeColor = true;
            this.barAndDockingController1.AppearancesDocking.PanelCaptionActive.Font = new System.Drawing.Font("黑体", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAndDockingController1.AppearancesDocking.PanelCaptionActive.ForeColor = System.Drawing.Color.Black;
            this.barAndDockingController1.AppearancesDocking.PanelCaptionActive.Options.UseFont = true;
            this.barAndDockingController1.AppearancesDocking.PanelCaptionActive.Options.UseForeColor = true;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // barManager1
            // 
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 542);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(995, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 542);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(995, 26);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // dockManager1
            // 
            this.dockManager1.Controller = this.barAndDockingController1;
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.ResourceContainer});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // ResourceContainer
            // 
            this.ResourceContainer.Controls.Add(this.dockPanel3_Container);
            this.ResourceContainer.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.ResourceContainer.FloatSize = new System.Drawing.Size(330, 200);
            this.ResourceContainer.Font = new System.Drawing.Font("黑体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResourceContainer.Footer = null;
            this.ResourceContainer.Header = null;
            this.ResourceContainer.ID = new System.Guid("1539c64a-1755-446f-b583-b0580e9ba1d7");
            this.ResourceContainer.Location = new System.Drawing.Point(695, 26);
            this.ResourceContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResourceContainer.Name = "ResourceContainer";
            this.ResourceContainer.OriginalSize = new System.Drawing.Size(300, 200);
            this.ResourceContainer.Size = new System.Drawing.Size(300, 516);
            this.ResourceContainer.Text = "资源目录";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.resourcePanel1);
            this.dockPanel3_Container.Location = new System.Drawing.Point(5, 23);
            this.dockPanel3_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(291, 489);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // resourcePanel1
            // 
            this.resourcePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcePanel1.Location = new System.Drawing.Point(0, 0);
            this.resourcePanel1.Name = "resourcePanel1";
            this.resourcePanel1.Size = new System.Drawing.Size(291, 489);
            this.resourcePanel1.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.LayersDockPanel);
            this.panelContainer1.Controls.Add(this.PropertiesDockPanel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatSize = new System.Drawing.Size(351, 200);
            this.panelContainer1.Footer = null;
            this.panelContainer1.Header = null;
            this.panelContainer1.ID = new System.Guid("12ee75ca-d68b-4d14-bfcf-76b9f3eebfbd");
            this.panelContainer1.Location = new System.Drawing.Point(0, 26);
            this.panelContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(300, 200);
            this.panelContainer1.Size = new System.Drawing.Size(300, 516);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // LayersDockPanel
            // 
            this.LayersDockPanel.Controls.Add(this.dockPanel2_Container);
            this.LayersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.LayersDockPanel.FloatSize = new System.Drawing.Size(50, 50);
            this.LayersDockPanel.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LayersDockPanel.Footer = null;
            this.LayersDockPanel.Header = null;
            this.LayersDockPanel.ID = new System.Guid("d1c1aeb8-8e7f-4a11-9a30-751d4bd0c5a6");
            this.LayersDockPanel.Location = new System.Drawing.Point(0, 0);
            this.LayersDockPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LayersDockPanel.Name = "LayersDockPanel";
            this.LayersDockPanel.Options.ShowAutoHideButton = false;
            this.LayersDockPanel.Options.ShowCloseButton = false;
            this.LayersDockPanel.Options.ShowMaximizeButton = false;
            this.LayersDockPanel.OriginalSize = new System.Drawing.Size(300, 192);
            this.LayersDockPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayersDockPanel.Size = new System.Drawing.Size(300, 192);
            this.LayersDockPanel.Text = "图层";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(291, 164);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // PropertiesDockPanel
            // 
            this.PropertiesDockPanel.Controls.Add(this.dockPanel1_Container);
            this.PropertiesDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.PropertiesDockPanel.FloatSize = new System.Drawing.Size(600, 492);
            this.PropertiesDockPanel.FloatVertical = true;
            this.PropertiesDockPanel.Font = new System.Drawing.Font("黑体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesDockPanel.Footer = null;
            this.PropertiesDockPanel.Header = null;
            this.PropertiesDockPanel.ID = new System.Guid("58c0c721-7d02-4c1a-ba0f-7010bc2df956");
            this.PropertiesDockPanel.Location = new System.Drawing.Point(0, 192);
            this.PropertiesDockPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropertiesDockPanel.Name = "PropertiesDockPanel";
            this.PropertiesDockPanel.Options.ShowAutoHideButton = false;
            this.PropertiesDockPanel.Options.ShowMaximizeButton = false;
            this.PropertiesDockPanel.OriginalSize = new System.Drawing.Size(300, 324);
            this.PropertiesDockPanel.Size = new System.Drawing.Size(300, 324);
            this.PropertiesDockPanel.Text = "属性";
            this.PropertiesDockPanel.Click += new System.EventHandler(this.PropertiesDockPanel_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(291, 297);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // DocumentManagerDocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResourceContainer);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocumentManagerDocking";
            this.Size = new System.Drawing.Size(995, 542);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResourceContainer.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.LayersDockPanel.ResumeLayout(false);
            this.PropertiesDockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Docking.DockPanel PropertiesDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel LayersDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel ResourceContainer;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private Resources.ResourcePanel resourcePanel1;
    }
}
