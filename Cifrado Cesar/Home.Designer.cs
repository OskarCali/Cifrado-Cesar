namespace Cifrado_Cesar
{
    partial class formHome
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxCipher = new System.Windows.Forms.GroupBox();
            this.numUDMove = new System.Windows.Forms.NumericUpDown();
            this.lblMove = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radBtnDiscipher = new System.Windows.Forms.RadioButton();
            this.radBtnCipher = new System.Windows.Forms.RadioButton();
            this.cmbBxOptions = new System.Windows.Forms.ComboBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cmbBxAbc = new System.Windows.Forms.ComboBox();
            this.lblAbc = new System.Windows.Forms.Label();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContInfo = new System.Windows.Forms.SplitContainer();
            this.richTxtBxAbc = new System.Windows.Forms.RichTextBox();
            this.splitContCesar = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.richTxtBxResult = new System.Windows.Forms.RichTextBox();
            this.grpBxCipher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMove)).BeginInit();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            this.stStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).BeginInit();
            this.splitContInfo.Panel1.SuspendLayout();
            this.splitContInfo.Panel2.SuspendLayout();
            this.splitContInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContCesar)).BeginInit();
            this.splitContCesar.Panel1.SuspendLayout();
            this.splitContCesar.Panel2.SuspendLayout();
            this.splitContCesar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1123, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CIFRADO CESAR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxCipher
            // 
            this.grpBxCipher.Controls.Add(this.numUDMove);
            this.grpBxCipher.Controls.Add(this.lblMove);
            this.grpBxCipher.Controls.Add(this.btnShowHide);
            this.grpBxCipher.Controls.Add(this.btnCalculate);
            this.grpBxCipher.Controls.Add(this.radBtnDiscipher);
            this.grpBxCipher.Controls.Add(this.radBtnCipher);
            this.grpBxCipher.Controls.Add(this.cmbBxOptions);
            this.grpBxCipher.Controls.Add(this.lblOptions);
            this.grpBxCipher.Controls.Add(this.cmbBxAbc);
            this.grpBxCipher.Controls.Add(this.lblAbc);
            this.grpBxCipher.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxCipher.Location = new System.Drawing.Point(0, 60);
            this.grpBxCipher.Margin = new System.Windows.Forms.Padding(0);
            this.grpBxCipher.Name = "grpBxCipher";
            this.grpBxCipher.Size = new System.Drawing.Size(1123, 100);
            this.grpBxCipher.TabIndex = 1;
            this.grpBxCipher.TabStop = false;
            this.grpBxCipher.Text = "Cifrado";
            // 
            // numUDMove
            // 
            this.numUDMove.Location = new System.Drawing.Point(579, 27);
            this.numUDMove.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numUDMove.Name = "numUDMove";
            this.numUDMove.ReadOnly = true;
            this.numUDMove.Size = new System.Drawing.Size(120, 22);
            this.numUDMove.TabIndex = 9;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(502, 29);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(71, 17);
            this.lblMove.TabIndex = 8;
            this.lblMove.Text = "Desplazo:";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.Location = new System.Drawing.Point(981, 29);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(120, 45);
            this.btnShowHide.TabIndex = 7;
            this.btnShowHide.Text = "OCULTAR";
            this.btnShowHide.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(800, 29);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // radBtnDiscipher
            // 
            this.radBtnDiscipher.AutoSize = true;
            this.radBtnDiscipher.Location = new System.Drawing.Point(348, 63);
            this.radBtnDiscipher.Name = "radBtnDiscipher";
            this.radBtnDiscipher.Size = new System.Drawing.Size(86, 21);
            this.radBtnDiscipher.TabIndex = 5;
            this.radBtnDiscipher.TabStop = true;
            this.radBtnDiscipher.Text = "Descifrar";
            this.radBtnDiscipher.UseVisualStyleBackColor = true;
            // 
            // radBtnCipher
            // 
            this.radBtnCipher.AutoSize = true;
            this.radBtnCipher.Location = new System.Drawing.Point(348, 27);
            this.radBtnCipher.Name = "radBtnCipher";
            this.radBtnCipher.Size = new System.Drawing.Size(63, 21);
            this.radBtnCipher.TabIndex = 4;
            this.radBtnCipher.TabStop = true;
            this.radBtnCipher.Text = "Cifrar";
            this.radBtnCipher.UseVisualStyleBackColor = true;
            // 
            // cmbBxOptions
            // 
            this.cmbBxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxOptions.FormattingEnabled = true;
            this.cmbBxOptions.Items.AddRange(new object[] {
            "Minusculas",
            "Mayusculas",
            "Ambas"});
            this.cmbBxOptions.Location = new System.Drawing.Point(117, 62);
            this.cmbBxOptions.Name = "cmbBxOptions";
            this.cmbBxOptions.Size = new System.Drawing.Size(140, 24);
            this.cmbBxOptions.TabIndex = 3;
            this.cmbBxOptions.SelectedIndexChanged += new System.EventHandler(this.CmbBxOptions_SelectedIndexChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(15, 65);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(72, 17);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Opciones:";
            // 
            // cmbBxAbc
            // 
            this.cmbBxAbc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxAbc.FormattingEnabled = true;
            this.cmbBxAbc.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmbBxAbc.Location = new System.Drawing.Point(117, 26);
            this.cmbBxAbc.Name = "cmbBxAbc";
            this.cmbBxAbc.Size = new System.Drawing.Size(140, 24);
            this.cmbBxAbc.TabIndex = 1;
            this.cmbBxAbc.SelectedIndexChanged += new System.EventHandler(this.CmbBxAbc_SelectedIndexChanged);
            // 
            // lblAbc
            // 
            this.lblAbc.AutoSize = true;
            this.lblAbc.Location = new System.Drawing.Point(15, 29);
            this.lblAbc.Name = "lblAbc";
            this.lblAbc.Size = new System.Drawing.Size(84, 17);
            this.lblAbc.TabIndex = 0;
            this.lblAbc.Text = "Abecedario:";
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitContInfo);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1123, 495);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 160);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1123, 521);
            this.toolStripCont.TabIndex = 2;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStLblInfo});
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(1123, 26);
            this.stStrip.TabIndex = 0;
            // 
            // toolStripStLblInfo
            // 
            this.toolStripStLblInfo.Name = "toolStripStLblInfo";
            this.toolStripStLblInfo.Size = new System.Drawing.Size(1108, 20);
            this.toolStripStLblInfo.Spring = true;
            this.toolStripStLblInfo.Text = "Total Caracteres";
            this.toolStripStLblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContInfo
            // 
            this.splitContInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContInfo.Name = "splitContInfo";
            this.splitContInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContInfo.Panel1
            // 
            this.splitContInfo.Panel1.Controls.Add(this.richTxtBxAbc);
            this.splitContInfo.Panel1MinSize = 60;
            // 
            // splitContInfo.Panel2
            // 
            this.splitContInfo.Panel2.Controls.Add(this.splitContCesar);
            this.splitContInfo.Panel2MinSize = 400;
            this.splitContInfo.Size = new System.Drawing.Size(1123, 495);
            this.splitContInfo.SplitterDistance = 62;
            this.splitContInfo.TabIndex = 0;
            // 
            // richTxtBxAbc
            // 
            this.richTxtBxAbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxAbc.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxAbc.Name = "richTxtBxAbc";
            this.richTxtBxAbc.ReadOnly = true;
            this.richTxtBxAbc.Size = new System.Drawing.Size(1123, 62);
            this.richTxtBxAbc.TabIndex = 0;
            this.richTxtBxAbc.Text = "";
            // 
            // splitContCesar
            // 
            this.splitContCesar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContCesar.Location = new System.Drawing.Point(0, 0);
            this.splitContCesar.Name = "splitContCesar";
            // 
            // splitContCesar.Panel1
            // 
            this.splitContCesar.Panel1.Controls.Add(this.richTxtBxSource);
            // 
            // splitContCesar.Panel2
            // 
            this.splitContCesar.Panel2.Controls.Add(this.richTxtBxResult);
            this.splitContCesar.Size = new System.Drawing.Size(1123, 429);
            this.splitContCesar.SplitterDistance = 541;
            this.splitContCesar.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(541, 429);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            // 
            // richTxtBxResult
            // 
            this.richTxtBxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxResult.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxResult.Name = "richTxtBxResult";
            this.richTxtBxResult.ReadOnly = true;
            this.richTxtBxResult.Size = new System.Drawing.Size(578, 429);
            this.richTxtBxResult.TabIndex = 0;
            this.richTxtBxResult.Text = "";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 681);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxCipher);
            this.Controls.Add(this.lblTitle);
            this.Name = "formHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpBxCipher.ResumeLayout(false);
            this.grpBxCipher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMove)).EndInit();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.splitContInfo.Panel1.ResumeLayout(false);
            this.splitContInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContInfo)).EndInit();
            this.splitContInfo.ResumeLayout(false);
            this.splitContCesar.Panel1.ResumeLayout(false);
            this.splitContCesar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContCesar)).EndInit();
            this.splitContCesar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxCipher;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radBtnDiscipher;
        private System.Windows.Forms.RadioButton radBtnCipher;
        private System.Windows.Forms.ComboBox cmbBxOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cmbBxAbc;
        private System.Windows.Forms.Label lblAbc;
        private System.Windows.Forms.SplitContainer splitContInfo;
        private System.Windows.Forms.RichTextBox richTxtBxAbc;
        private System.Windows.Forms.SplitContainer splitContCesar;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.RichTextBox richTxtBxResult;
        private System.Windows.Forms.NumericUpDown numUDMove;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStLblInfo;
    }
}

