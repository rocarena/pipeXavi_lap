namespace pipebender
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pumpBtn = new System.Windows.Forms.Button();
            this.sinkBtn = new System.Windows.Forms.Button();
            this.mergerBtn = new System.Windows.Forms.Button();
            this.normalSplitterBtn = new System.Windows.Forms.Button();
            this.regSplitterBtn = new System.Windows.Forms.Button();
            this.menuImages = new System.Windows.Forms.ImageList(this.components);
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPipe = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pumpBtn
            // 
            this.pumpBtn.Location = new System.Drawing.Point(13, 12);
            this.pumpBtn.Name = "pumpBtn";
            this.pumpBtn.Size = new System.Drawing.Size(75, 23);
            this.pumpBtn.TabIndex = 0;
            this.pumpBtn.Text = "Pump";
            this.pumpBtn.UseVisualStyleBackColor = true;
            this.pumpBtn.Click += new System.EventHandler(this.pumpBtn_Click);
            // 
            // sinkBtn
            // 
            this.sinkBtn.Location = new System.Drawing.Point(94, 12);
            this.sinkBtn.Name = "sinkBtn";
            this.sinkBtn.Size = new System.Drawing.Size(75, 23);
            this.sinkBtn.TabIndex = 1;
            this.sinkBtn.Text = "Sink";
            this.sinkBtn.UseVisualStyleBackColor = true;
            this.sinkBtn.Click += new System.EventHandler(this.sinkBtn_Click);
            // 
            // mergerBtn
            // 
            this.mergerBtn.Location = new System.Drawing.Point(175, 12);
            this.mergerBtn.Name = "mergerBtn";
            this.mergerBtn.Size = new System.Drawing.Size(75, 23);
            this.mergerBtn.TabIndex = 2;
            this.mergerBtn.Text = "Merger";
            this.mergerBtn.UseVisualStyleBackColor = true;
            this.mergerBtn.Click += new System.EventHandler(this.mergerBtn_Click);
            // 
            // normalSplitterBtn
            // 
            this.normalSplitterBtn.Location = new System.Drawing.Point(256, 12);
            this.normalSplitterBtn.Name = "normalSplitterBtn";
            this.normalSplitterBtn.Size = new System.Drawing.Size(75, 23);
            this.normalSplitterBtn.TabIndex = 3;
            this.normalSplitterBtn.Text = "Normal";
            this.normalSplitterBtn.UseVisualStyleBackColor = true;
            this.normalSplitterBtn.Click += new System.EventHandler(this.normalSplitterBtn_Click);
            // 
            // regSplitterBtn
            // 
            this.regSplitterBtn.Location = new System.Drawing.Point(337, 12);
            this.regSplitterBtn.Name = "regSplitterBtn";
            this.regSplitterBtn.Size = new System.Drawing.Size(75, 23);
            this.regSplitterBtn.TabIndex = 4;
            this.regSplitterBtn.Text = "Regulable";
            this.regSplitterBtn.UseVisualStyleBackColor = true;
            this.regSplitterBtn.Click += new System.EventHandler(this.regSplitterBtn_Click);
            // 
            // menuImages
            // 
            this.menuImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuImages.ImageStream")));
            this.menuImages.TransparentColor = System.Drawing.Color.Transparent;
            this.menuImages.Images.SetKeyName(0, "Pump.png");
            this.menuImages.Images.SetKeyName(1, "Sink.png");
            this.menuImages.Images.SetKeyName(2, "NormalSplitter.png");
            this.menuImages.Images.SetKeyName(3, "RegulableSplitter.png");
            this.menuImages.Images.SetKeyName(4, "Merger.png");
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(12, 42);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(893, 440);
            this.mapBox.TabIndex = 5;
            this.mapBox.TabStop = false;
            this.mapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mapBox_Paint);
            this.mapBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapBox_MouseClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(582, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.removeBtn);
            // 
            // buttonPipe
            // 
            this.buttonPipe.Location = new System.Drawing.Point(418, 12);
            this.buttonPipe.Name = "buttonPipe";
            this.buttonPipe.Size = new System.Drawing.Size(75, 23);
            this.buttonPipe.TabIndex = 8;
            this.buttonPipe.Text = "Pipe";
            this.buttonPipe.UseVisualStyleBackColor = true;
            this.buttonPipe.Click += new System.EventHandler(this.buttonPipe_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = " (*.txt)|";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(676, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open ";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(768, 12);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 10;
            this.buttonSaveAs.Text = "Save As";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonPipe);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.regSplitterBtn);
            this.Controls.Add(this.normalSplitterBtn);
            this.Controls.Add(this.mergerBtn);
            this.Controls.Add(this.sinkBtn);
            this.Controls.Add(this.pumpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipebender";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pumpBtn;
        private System.Windows.Forms.Button sinkBtn;
        private System.Windows.Forms.Button mergerBtn;
        private System.Windows.Forms.Button normalSplitterBtn;
        private System.Windows.Forms.Button regSplitterBtn;
        private System.Windows.Forms.ImageList menuImages;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPipe;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSaveAs;
    }
}

