using System;
using System.Collections.Generic;
using System.Linq;

namespace NAPS2.WinForms
{
    partial class FDesktop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDesktop));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomMouseCatcher = new System.Windows.Forms.Button();
            this.thumbnailList1 = new NAPS2.WinForms.ThumbnailList();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxView = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsScan = new System.Windows.Forms.ToolStripSplitButton();
            this.tsNewProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBatchScan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProfiles = new System.Windows.Forms.ToolStripButton();
            this.tsOcr = new System.Windows.Forms.ToolStripButton();
            this.tsImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdSavePDF = new System.Windows.Forms.ToolStripSplitButton();
            this.tsSavePDFAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSavePDFSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPDFSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdSaveImages = new System.Windows.Forms.ToolStripSplitButton();
            this.tsSaveImagesAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveImagesSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImageSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdEmailPDF = new System.Windows.Forms.ToolStripSplitButton();
            this.tsEmailPDFAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmailPDFSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsEmailSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPdfSettings2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsdImage = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCrop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBrightnessContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHueSaturation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBlackWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdRotate = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsRotateLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRotateRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeskew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCustomRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMove = new NAPS2.WinForms.ToolStripDoubleButton();
            this.tsdReorder = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsInterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeinterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAltInterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltDeinterleave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReverseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReverseSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsAbout = new System.Windows.Forms.ToolStripButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnScan);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnZoomIn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnZoomOut);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnZoomMouseCatcher);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.thumbnailList1);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tStrip);
            // 
            // btnZoomIn
            // 
            resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
            this.btnZoomIn.BackColor = System.Drawing.Color.White;
            this.btnZoomIn.Image = global::NAPS2.Icons.zoom_in;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            // 
            // btnZoomOut
            // 
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.BackColor = System.Drawing.Color.White;
            this.btnZoomOut.Image = global::NAPS2.Icons.zoom_out;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            // 
            // btnZoomMouseCatcher
            // 
            this.btnZoomMouseCatcher.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnZoomMouseCatcher, "btnZoomMouseCatcher");
            this.btnZoomMouseCatcher.Name = "btnZoomMouseCatcher";
            this.btnZoomMouseCatcher.UseVisualStyleBackColor = false;
            // 
            // thumbnailList1
            // 
            this.thumbnailList1.AllowDrop = true;
            this.thumbnailList1.ContextMenuStrip = this.contextMenuStrip;
            resources.ApplyResources(this.thumbnailList1, "thumbnailList1");
            this.thumbnailList1.Name = "thumbnailList1";
            this.thumbnailList1.ThumbnailRenderer = null;
            this.thumbnailList1.ThumbnailSize = new System.Drawing.Size(128, 128);
            this.thumbnailList1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxView,
            this.ctxSeparator1,
            this.ctxSelectAll,
            this.ctxCopy,
            this.ctxPaste,
            this.ctxSeparator2,
            this.ctxDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // ctxView
            // 
            resources.ApplyResources(this.ctxView, "ctxView");
            this.ctxView.Name = "ctxView";
            // 
            // ctxSeparator1
            // 
            this.ctxSeparator1.Name = "ctxSeparator1";
            resources.ApplyResources(this.ctxSeparator1, "ctxSeparator1");
            // 
            // ctxSelectAll
            // 
            this.ctxSelectAll.Name = "ctxSelectAll";
            resources.ApplyResources(this.ctxSelectAll, "ctxSelectAll");
            // 
            // ctxCopy
            // 
            this.ctxCopy.Name = "ctxCopy";
            resources.ApplyResources(this.ctxCopy, "ctxCopy");
            // 
            // ctxPaste
            // 
            this.ctxPaste.Name = "ctxPaste";
            resources.ApplyResources(this.ctxPaste, "ctxPaste");
            // 
            // ctxSeparator2
            // 
            this.ctxSeparator2.Name = "ctxSeparator2";
            resources.ApplyResources(this.ctxSeparator2, "ctxSeparator2");
            // 
            // ctxDelete
            // 
            this.ctxDelete.Name = "ctxDelete";
            resources.ApplyResources(this.ctxDelete, "ctxDelete");
            // 
            // tStrip
            // 
            resources.ApplyResources(this.tStrip, "tStrip");
            this.tStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsScan,
            this.tsProfiles,
            this.tsOcr,
            this.tsImport,
            this.toolStripSeparator5,
            this.tsdSavePDF,
            this.tsdSaveImages,
            this.tsdEmailPDF,
            this.tsPrint,
            this.toolStripSeparator4,
            this.tsdImage,
            this.tsdRotate,
            this.tsMove,
            this.tsdReorder,
            this.toolStripSeparator2,
            this.tsDelete,
            this.tsClear,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.tsAbout});
            this.tStrip.Name = "tStrip";
            this.tStrip.ShowItemToolTips = false;
            this.tStrip.TabStop = true;
            // 
            // tsScan
            // 
            this.tsScan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewProfile,
            this.tsBatchScan});
            this.tsScan.Image = global::NAPS2.Icons.control_play_blue;
            resources.ApplyResources(this.tsScan, "tsScan");
            this.tsScan.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsScan.Name = "tsScan";
            this.tsScan.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsScan.ButtonClick += new System.EventHandler(this.tsScan_ButtonClick);
            // 
            // tsNewProfile
            // 
            this.tsNewProfile.Image = global::NAPS2.Icons.add_small;
            resources.ApplyResources(this.tsNewProfile, "tsNewProfile");
            this.tsNewProfile.Name = "tsNewProfile";
            this.tsNewProfile.Click += new System.EventHandler(this.tsNewProfile_Click);
            // 
            // tsBatchScan
            // 
            this.tsBatchScan.Image = global::NAPS2.Icons.application_cascade;
            resources.ApplyResources(this.tsBatchScan, "tsBatchScan");
            this.tsBatchScan.Name = "tsBatchScan";
            // 
            // tsProfiles
            // 
            resources.ApplyResources(this.tsProfiles, "tsProfiles");
            this.tsProfiles.Name = "tsProfiles";
            this.tsProfiles.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsProfiles.Click += new System.EventHandler(this.tsProfiles_Click);
            // 
            // tsOcr
            // 
            this.tsOcr.Image = global::NAPS2.Icons.text;
            resources.ApplyResources(this.tsOcr, "tsOcr");
            this.tsOcr.Name = "tsOcr";
            this.tsOcr.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // tsImport
            // 
            this.tsImport.Image = global::NAPS2.Icons.folder_picture;
            resources.ApplyResources(this.tsImport, "tsImport");
            this.tsImport.Name = "tsImport";
            this.tsImport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // tsdSavePDF
            // 
            this.tsdSavePDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSavePDFAll,
            this.tsSavePDFSelected,
            this.toolStripSeparator10,
            this.tsPDFSettings});
            this.tsdSavePDF.Image = global::NAPS2.Icons.file_extension_pdf;
            resources.ApplyResources(this.tsdSavePDF, "tsdSavePDF");
            this.tsdSavePDF.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsdSavePDF.Name = "tsdSavePDF";
            this.tsdSavePDF.ButtonClick += new System.EventHandler(this.tsdSavePDF_ButtonClick);
            // 
            // tsSavePDFAll
            // 
            this.tsSavePDFAll.Name = "tsSavePDFAll";
            resources.ApplyResources(this.tsSavePDFAll, "tsSavePDFAll");
            // 
            // tsSavePDFSelected
            // 
            this.tsSavePDFSelected.Name = "tsSavePDFSelected";
            resources.ApplyResources(this.tsSavePDFSelected, "tsSavePDFSelected");
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // tsPDFSettings
            // 
            this.tsPDFSettings.Name = "tsPDFSettings";
            resources.ApplyResources(this.tsPDFSettings, "tsPDFSettings");
            // 
            // tsdSaveImages
            // 
            this.tsdSaveImages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveImagesAll,
            this.tsSaveImagesSelected,
            this.toolStripSeparator11,
            this.tsImageSettings});
            this.tsdSaveImages.Image = global::NAPS2.Icons.pictures;
            resources.ApplyResources(this.tsdSaveImages, "tsdSaveImages");
            this.tsdSaveImages.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsdSaveImages.Name = "tsdSaveImages";
            // 
            // tsSaveImagesAll
            // 
            this.tsSaveImagesAll.Name = "tsSaveImagesAll";
            resources.ApplyResources(this.tsSaveImagesAll, "tsSaveImagesAll");
            // 
            // tsSaveImagesSelected
            // 
            this.tsSaveImagesSelected.Name = "tsSaveImagesSelected";
            resources.ApplyResources(this.tsSaveImagesSelected, "tsSaveImagesSelected");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // tsImageSettings
            // 
            this.tsImageSettings.Name = "tsImageSettings";
            resources.ApplyResources(this.tsImageSettings, "tsImageSettings");
            // 
            // tsdEmailPDF
            // 
            this.tsdEmailPDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmailPDFAll,
            this.tsEmailPDFSelected,
            this.toolStripSeparator9,
            this.tsEmailSettings,
            this.tsPdfSettings2});
            this.tsdEmailPDF.Image = global::NAPS2.Icons.email_attach;
            resources.ApplyResources(this.tsdEmailPDF, "tsdEmailPDF");
            this.tsdEmailPDF.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsdEmailPDF.Name = "tsdEmailPDF";
            // 
            // tsEmailPDFAll
            // 
            this.tsEmailPDFAll.Name = "tsEmailPDFAll";
            resources.ApplyResources(this.tsEmailPDFAll, "tsEmailPDFAll");
            // 
            // tsEmailPDFSelected
            // 
            this.tsEmailPDFSelected.Name = "tsEmailPDFSelected";
            resources.ApplyResources(this.tsEmailPDFSelected, "tsEmailPDFSelected");
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // tsEmailSettings
            // 
            this.tsEmailSettings.Name = "tsEmailSettings";
            resources.ApplyResources(this.tsEmailSettings, "tsEmailSettings");
            // 
            // tsPdfSettings2
            // 
            this.tsPdfSettings2.Name = "tsPdfSettings2";
            resources.ApplyResources(this.tsPdfSettings2, "tsPdfSettings2");
            // 
            // tsPrint
            // 
            this.tsPrint.Image = global::NAPS2.Icons.printer;
            resources.ApplyResources(this.tsPrint, "tsPrint");
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsdImage
            // 
            this.tsdImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsView,
            this.toolStripSeparator6,
            this.tsCrop,
            this.tsBrightnessContrast,
            this.tsHueSaturation,
            this.tsBlackWhite,
            this.tsSharpen,
            this.toolStripSeparator7,
            this.tsReset});
            this.tsdImage.Image = global::NAPS2.Icons.picture_edit;
            resources.ApplyResources(this.tsdImage, "tsdImage");
            this.tsdImage.Name = "tsdImage";
            this.tsdImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdImage.ShowDropDownArrow = false;
            // 
            // tsView
            // 
            this.tsView.Name = "tsView";
            resources.ApplyResources(this.tsView, "tsView");
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // tsCrop
            // 
            this.tsCrop.Image = global::NAPS2.Icons.transform_crop;
            resources.ApplyResources(this.tsCrop, "tsCrop");
            this.tsCrop.Name = "tsCrop";
            // 
            // tsBrightnessContrast
            // 
            this.tsBrightnessContrast.Image = global::NAPS2.Icons.contrast_with_sun;
            resources.ApplyResources(this.tsBrightnessContrast, "tsBrightnessContrast");
            this.tsBrightnessContrast.Name = "tsBrightnessContrast";
            // 
            // tsHueSaturation
            // 
            this.tsHueSaturation.Image = global::NAPS2.Icons.color_management;
            resources.ApplyResources(this.tsHueSaturation, "tsHueSaturation");
            this.tsHueSaturation.Name = "tsHueSaturation";
            // 
            // tsBlackWhite
            // 
            this.tsBlackWhite.Image = global::NAPS2.Icons.contrast_high;
            resources.ApplyResources(this.tsBlackWhite, "tsBlackWhite");
            this.tsBlackWhite.Name = "tsBlackWhite";
            // 
            // tsSharpen
            // 
            this.tsSharpen.Image = global::NAPS2.Icons.sharpen;
            resources.ApplyResources(this.tsSharpen, "tsSharpen");
            this.tsSharpen.Name = "tsSharpen";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // tsReset
            // 
            this.tsReset.Name = "tsReset";
            resources.ApplyResources(this.tsReset, "tsReset");
            // 
            // tsdRotate
            // 
            this.tsdRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRotateLeft,
            this.tsRotateRight,
            this.tsFlip,
            this.tsDeskew,
            this.tsCustomRotation});
            this.tsdRotate.Image = global::NAPS2.Icons.arrow_rotate_anticlockwise;
            resources.ApplyResources(this.tsdRotate, "tsdRotate");
            this.tsdRotate.Name = "tsdRotate";
            this.tsdRotate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdRotate.ShowDropDownArrow = false;
            // 
            // tsRotateLeft
            // 
            this.tsRotateLeft.Image = global::NAPS2.Icons.arrow_rotate_anticlockwise_small;
            resources.ApplyResources(this.tsRotateLeft, "tsRotateLeft");
            this.tsRotateLeft.Name = "tsRotateLeft";
            // 
            // tsRotateRight
            // 
            this.tsRotateRight.Image = global::NAPS2.Icons.arrow_rotate_clockwise_small;
            resources.ApplyResources(this.tsRotateRight, "tsRotateRight");
            this.tsRotateRight.Name = "tsRotateRight";
            // 
            // tsFlip
            // 
            this.tsFlip.Image = global::NAPS2.Icons.arrow_switch_small;
            resources.ApplyResources(this.tsFlip, "tsFlip");
            this.tsFlip.Name = "tsFlip";
            // 
            // tsDeskew
            // 
            resources.ApplyResources(this.tsDeskew, "tsDeskew");
            this.tsDeskew.Name = "tsDeskew";
            // 
            // tsCustomRotation
            // 
            this.tsCustomRotation.Name = "tsCustomRotation";
            resources.ApplyResources(this.tsCustomRotation, "tsCustomRotation");
            // 
            // tsMove
            // 
            this.tsMove.FirstImage = global::NAPS2.Icons.arrow_up_small;
            resources.ApplyResources(this.tsMove, "tsMove");
            this.tsMove.MaxTextWidth = 80;
            this.tsMove.Name = "tsMove";
            this.tsMove.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsMove.SecondImage = global::NAPS2.Icons.arrow_down_small;
            this.tsMove.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsdReorder
            // 
            this.tsdReorder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInterleave,
            this.tsDeinterleave,
            this.toolStripSeparator12,
            this.tsAltInterleave,
            this.tsAltDeinterleave,
            this.toolStripSeparator1,
            this.tsReverse});
            this.tsdReorder.Image = global::NAPS2.Icons.arrow_refresh;
            resources.ApplyResources(this.tsdReorder, "tsdReorder");
            this.tsdReorder.Name = "tsdReorder";
            this.tsdReorder.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsdReorder.ShowDropDownArrow = false;
            // 
            // tsInterleave
            // 
            this.tsInterleave.Name = "tsInterleave";
            resources.ApplyResources(this.tsInterleave, "tsInterleave");
            // 
            // tsDeinterleave
            // 
            this.tsDeinterleave.Name = "tsDeinterleave";
            resources.ApplyResources(this.tsDeinterleave, "tsDeinterleave");
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // tsAltInterleave
            // 
            this.tsAltInterleave.Name = "tsAltInterleave";
            resources.ApplyResources(this.tsAltInterleave, "tsAltInterleave");
            // 
            // tsAltDeinterleave
            // 
            this.tsAltDeinterleave.Name = "tsAltDeinterleave";
            resources.ApplyResources(this.tsAltDeinterleave, "tsAltDeinterleave");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsReverse
            // 
            this.tsReverse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReverseAll,
            this.tsReverseSelected});
            this.tsReverse.Name = "tsReverse";
            resources.ApplyResources(this.tsReverse, "tsReverse");
            // 
            // tsReverseAll
            // 
            this.tsReverseAll.Name = "tsReverseAll";
            resources.ApplyResources(this.tsReverseAll, "tsReverseAll");
            // 
            // tsReverseSelected
            // 
            this.tsReverseSelected.Name = "tsReverseSelected";
            resources.ApplyResources(this.tsReverseSelected, "tsReverseSelected");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::NAPS2.Icons.cross;
            resources.ApplyResources(this.tsDelete, "tsDelete");
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // tsClear
            // 
            this.tsClear.Image = global::NAPS2.Icons.cancel;
            resources.ApplyResources(this.tsClear, "tsClear");
            this.tsClear.Name = "tsClear";
            this.tsClear.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Image = global::NAPS2.Icons.world;
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            // 
            // tsAbout
            // 
            resources.ApplyResources(this.tsAbout, "tsAbout");
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnScan
            // 
            resources.ApplyResources(this.btnScan, "btnScan");
            this.btnScan.Name = "btnScan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // FDesktop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Name = "FDesktop";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripSplitButton tsScan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private ThumbnailList thumbnailList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ToolStripDoubleButton tsMove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsProfiles;
        private System.Windows.Forms.ToolStripButton tsAbout;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton tsImport;
        private System.Windows.Forms.ToolStripSplitButton tsdSavePDF;
        private System.Windows.Forms.ToolStripMenuItem tsSavePDFAll;
        private System.Windows.Forms.ToolStripMenuItem tsSavePDFSelected;
        private System.Windows.Forms.ToolStripDropDownButton tsdRotate;
        private System.Windows.Forms.ToolStripMenuItem tsRotateLeft;
        private System.Windows.Forms.ToolStripMenuItem tsRotateRight;
        private System.Windows.Forms.ToolStripMenuItem tsFlip;
        private System.Windows.Forms.ToolStripDropDownButton tsdReorder;
        private System.Windows.Forms.ToolStripMenuItem tsInterleave;
        private System.Windows.Forms.ToolStripMenuItem tsDeinterleave;
        private System.Windows.Forms.ToolStripSplitButton tsdSaveImages;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImagesAll;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImagesSelected;
        private System.Windows.Forms.ToolStripSplitButton tsdEmailPDF;
        private System.Windows.Forms.ToolStripMenuItem tsEmailPDFAll;
        private System.Windows.Forms.ToolStripMenuItem tsEmailPDFSelected;
        private System.Windows.Forms.ToolStripButton tsOcr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxView;
        private System.Windows.Forms.ToolStripMenuItem ctxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsReverse;
        private System.Windows.Forms.ToolStripMenuItem tsReverseAll;
        private System.Windows.Forms.ToolStripMenuItem tsReverseSelected;
        private System.Windows.Forms.ToolStripMenuItem tsNewProfile;
        private System.Windows.Forms.ToolStripDropDownButton tsdImage;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsBrightnessContrast;
        private System.Windows.Forms.ToolStripMenuItem tsCrop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsReset;
        private System.Windows.Forms.ToolStripMenuItem tsCustomRotation;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsPDFSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsEmailSettings;
        private System.Windows.Forms.ToolStripMenuItem tsPdfSettings2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem tsImageSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsAltInterleave;
        private System.Windows.Forms.ToolStripMenuItem tsAltDeinterleave;
        private System.Windows.Forms.ToolStripMenuItem tsBatchScan;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxDelete;
        private System.Windows.Forms.Button btnZoomMouseCatcher;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripMenuItem tsDeskew;
        private System.Windows.Forms.ToolStripMenuItem tsSharpen;
        private System.Windows.Forms.ToolStripMenuItem tsHueSaturation;
        private System.Windows.Forms.ToolStripMenuItem tsBlackWhite;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnConnect;
    }
}

