﻿namespace VS.Report
{
    partial class rptDSDonVi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDSDonVi));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTIEU_DE = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblDIA_CHI = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCONG_TY = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.Title_Stt = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title_Ma = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title_Ten = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title_DiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title_TenTat = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDienThoai = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFax = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNguoiKy = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 190F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 192F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 93.98005F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(8.074442E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(2557F, 93.98005F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")});
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Page;
            this.xrTableCell1.Summary = xrSummary1;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.21262460899875688D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATA].[MS_DV]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.42713560950823115D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATA].[TEN_DV]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 1.4748519499817943D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATA].[DIA_CHI]")});
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 2.6161009537415145D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATA].[TEN_NGAN]")});
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.65976408042620627D;
            // 
            // lblTIEU_DE
            // 
            this.lblTIEU_DE.Dpi = 254F;
            this.lblTIEU_DE.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIEU_DE.LocationFloat = new DevExpress.Utils.PointFloat(0F, 224.0901F);
            this.lblTIEU_DE.Multiline = true;
            this.lblTIEU_DE.Name = "lblTIEU_DE";
            this.lblTIEU_DE.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.lblTIEU_DE.SizeF = new System.Drawing.SizeF(2557F, 148.2728F);
            this.lblTIEU_DE.StylePriority.UseFont = false;
            this.lblTIEU_DE.StylePriority.UsePadding = false;
            this.lblTIEU_DE.StylePriority.UseTextAlignment = false;
            this.lblTIEU_DE.Text = "lblTIEU_DE";
            this.lblTIEU_DE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 100.0125F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 254F;
            this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[TTC].[LOGO]")});
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(8.074442E-05F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(351.0986F, 202.4234F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // lblDIA_CHI
            // 
            this.lblDIA_CHI.AllowMarkupText = true;
            this.lblDIA_CHI.AutoWidth = true;
            this.lblDIA_CHI.Dpi = 254F;
            this.lblDIA_CHI.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TTC].[DIA_CHI]")});
            this.lblDIA_CHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIA_CHI.LocationFloat = new DevExpress.Utils.PointFloat(372.2662F, 74.99995F);
            this.lblDIA_CHI.Multiline = true;
            this.lblDIA_CHI.Name = "lblDIA_CHI";
            this.lblDIA_CHI.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblDIA_CHI.SizeF = new System.Drawing.SizeF(2184.734F, 63.7117F);
            this.lblDIA_CHI.StylePriority.UseFont = false;
            this.lblDIA_CHI.StylePriority.UseTextAlignment = false;
            this.lblDIA_CHI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblCONG_TY
            // 
            this.lblCONG_TY.AllowMarkupText = true;
            this.lblCONG_TY.AutoWidth = true;
            this.lblCONG_TY.Dpi = 254F;
            this.lblCONG_TY.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TTC].[TEN_CTY]")});
            this.lblCONG_TY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONG_TY.LocationFloat = new DevExpress.Utils.PointFloat(372.2662F, 0F);
            this.lblCONG_TY.Multiline = true;
            this.lblCONG_TY.Name = "lblCONG_TY";
            this.lblCONG_TY.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCONG_TY.SizeF = new System.Drawing.SizeF(2184.734F, 75.00002F);
            this.lblCONG_TY.StylePriority.UseFont = false;
            this.lblCONG_TY.StylePriority.UseTextAlignment = false;
            this.lblCONG_TY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Dpi = 254F;
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(2557F, 100.0125F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Title_Stt,
            this.Title_Ma,
            this.Title_Ten,
            this.Title_DiaChi,
            this.Title_TenTat});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1.0749993896484376D;
            // 
            // Title_Stt
            // 
            this.Title_Stt.Dpi = 254F;
            this.Title_Stt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Stt.Multiline = true;
            this.Title_Stt.Name = "Title_Stt";
            this.Title_Stt.RowSpan = 2;
            this.Title_Stt.StylePriority.UseFont = false;
            this.Title_Stt.StylePriority.UseTextAlignment = false;
            this.Title_Stt.Text = "Stt";
            this.Title_Stt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Title_Stt.Weight = 0.38877268443285723D;
            // 
            // Title_Ma
            // 
            this.Title_Ma.Dpi = 254F;
            this.Title_Ma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Ma.Multiline = true;
            this.Title_Ma.Name = "Title_Ma";
            this.Title_Ma.RowSpan = 2;
            this.Title_Ma.StylePriority.UseFont = false;
            this.Title_Ma.Text = "Title_Ma";
            this.Title_Ma.Weight = 0.78099402224806891D;
            // 
            // Title_Ten
            // 
            this.Title_Ten.Dpi = 254F;
            this.Title_Ten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Ten.Multiline = true;
            this.Title_Ten.Name = "Title_Ten";
            this.Title_Ten.RowSpan = 2;
            this.Title_Ten.StylePriority.UseFont = false;
            this.Title_Ten.Text = "Title_Ten";
            this.Title_Ten.Weight = 2.6966862061370409D;
            // 
            // Title_DiaChi
            // 
            this.Title_DiaChi.Dpi = 254F;
            this.Title_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_DiaChi.Multiline = true;
            this.Title_DiaChi.Name = "Title_DiaChi";
            this.Title_DiaChi.RowSpan = 2;
            this.Title_DiaChi.StylePriority.UseFont = false;
            this.Title_DiaChi.Text = "Title_DiaChi";
            this.Title_DiaChi.Weight = 4.7833952581740187D;
            // 
            // Title_TenTat
            // 
            this.Title_TenTat.Dpi = 254F;
            this.Title_TenTat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_TenTat.Multiline = true;
            this.Title_TenTat.Name = "Title_TenTat";
            this.Title_TenTat.StylePriority.UseFont = false;
            this.Title_TenTat.Text = "Title_TenTat";
            this.Title_TenTat.Weight = 1.2063426338526335D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AllowMarkupText = true;
            this.xrLabel1.AutoWidth = true;
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TTC].[FAX]")});
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1308.167F, 138.7117F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1248.833F, 63.7117F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AllowMarkupText = true;
            this.xrLabel2.AutoWidth = true;
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TTC].[DIEN_THOAI]")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(602.4537F, 138.7117F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(597.2338F, 63.7117F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AllowMarkupText = true;
            this.lblDienThoai.AutoWidth = true;
            this.lblDienThoai.Dpi = 254F;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.LocationFloat = new DevExpress.Utils.PointFloat(372.2662F, 138.7117F);
            this.lblDienThoai.Multiline = true;
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblDienThoai.SizeF = new System.Drawing.SizeF(230.1875F, 63.7117F);
            this.lblDienThoai.StylePriority.UseFont = false;
            this.lblDienThoai.StylePriority.UseTextAlignment = false;
            this.lblDienThoai.Text = "DT";
            this.lblDienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblFax
            // 
            this.lblFax.AllowMarkupText = true;
            this.lblFax.AutoWidth = true;
            this.lblFax.Dpi = 254F;
            this.lblFax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFax.LocationFloat = new DevExpress.Utils.PointFloat(1199.687F, 138.7117F);
            this.lblFax.Multiline = true;
            this.lblFax.Name = "lblFax";
            this.lblFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblFax.SizeF = new System.Drawing.SizeF(108.4792F, 63.7117F);
            this.lblFax.StylePriority.UseFont = false;
            this.lblFax.StylePriority.UseTextAlignment = false;
            this.lblFax.Text = "Fax";
            this.lblFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNguoiKy,
            this.lblNgay});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 152.4233F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTIEU_DE,
            this.lblFax,
            this.lblDienThoai,
            this.xrLabel2,
            this.xrLabel1,
            this.lblDIA_CHI,
            this.lblCONG_TY,
            this.xrPictureBox1});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 389.9375F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblNgay
            // 
            this.lblNgay.AllowMarkupText = true;
            this.lblNgay.AutoWidth = true;
            this.lblNgay.Dpi = 254F;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.LocationFloat = new DevExpress.Utils.PointFloat(1897.854F, 24.99993F);
            this.lblNgay.Multiline = true;
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblNgay.SizeF = new System.Drawing.SizeF(603.25F, 63.71169F);
            this.lblNgay.StylePriority.UseFont = false;
            this.lblNgay.StylePriority.UseTextAlignment = false;
            this.lblNgay.Text = "NGAY";
            this.lblNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNguoiKy
            // 
            this.lblNguoiKy.AllowMarkupText = true;
            this.lblNguoiKy.AutoWidth = true;
            this.lblNguoiKy.Dpi = 254F;
            this.lblNguoiKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiKy.LocationFloat = new DevExpress.Utils.PointFloat(1897.854F, 88.71164F);
            this.lblNguoiKy.Multiline = true;
            this.lblNguoiKy.Name = "lblNguoiKy";
            this.lblNguoiKy.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblNguoiKy.SizeF = new System.Drawing.SizeF(603.25F, 63.7117F);
            this.lblNguoiKy.StylePriority.UseFont = false;
            this.lblNguoiKy.StylePriority.UseTextAlignment = false;
            this.lblNguoiKy.Text = "NGUOI_KY";
            this.lblNguoiKy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rptDSDonVi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.ReportFooter,
            this.ReportHeader});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(196, 214, 190, 192);
            this.PageHeight = 2100;
            this.PageWidth = 2970;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Tag = "rptDSDonVi";
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lblTIEU_DE;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel lblDIA_CHI;
        private DevExpress.XtraReports.UI.XRLabel lblCONG_TY;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell Title_Stt;
        private DevExpress.XtraReports.UI.XRTableCell Title_Ma;
        private DevExpress.XtraReports.UI.XRTableCell Title_Ten;
        private DevExpress.XtraReports.UI.XRTableCell Title_DiaChi;
        private DevExpress.XtraReports.UI.XRTableCell Title_TenTat;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lblFax;
        private DevExpress.XtraReports.UI.XRLabel lblDienThoai;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblNguoiKy;
        private DevExpress.XtraReports.UI.XRLabel lblNgay;
    }
}
