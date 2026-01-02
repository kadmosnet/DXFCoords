namespace DXFCoords
{
    partial class Form1
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
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCoords = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoords)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-11, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load DXF file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCoords
            // 
            this.dataGridViewCoords.AllowUserToAddRows = false;
            this.dataGridViewCoords.AllowUserToDeleteRows = false;
            this.dataGridViewCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoords.ColumnHeadersVisible = false;
            this.dataGridViewCoords.Location = new System.Drawing.Point(510, 1);
            this.dataGridViewCoords.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCoords.Name = "dataGridViewCoords";
            this.dataGridViewCoords.ReadOnly = true;
            this.dataGridViewCoords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCoords.RowHeadersVisible = false;
            this.dataGridViewCoords.RowTemplate.Height = 24;
            this.dataGridViewCoords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCoords.Size = new System.Drawing.Size(384, 521);
            this.dataGridViewCoords.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "List coords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            this.dxfReaderNETControl1.CustomCursorColor = System.Drawing.Color.White;
            this.dxfReaderNETControl1.DistributionCode = "";
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = ((short)(256));
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new System.DateTime(2023, 6, 16, 9, 7, 19, 741);
            dxfDocument1.DateLastEdited = new System.DateTime(2023, 6, 16, 9, 7, 19, 741);
            dxfDocument1.Handle = "0";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "2A";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.SortentsTables = null;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.GrabPointsSize = 8;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHover = false;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(3, 1);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.RubberBandColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGrid = true;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(502, 521);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewCoords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DXFReaderNET Componet - Extract coordinates form DXF file";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCoords;
        private System.Windows.Forms.Button button2;
    }
}

