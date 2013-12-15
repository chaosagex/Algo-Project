namespace ImageFilters
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.btnRemoveNoise = new System.Windows.Forms.Button();
            this.numWindowSize = new System.Windows.Forms.NumericUpDown();
            this.numTrimValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 458);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnZGraph
            // 
            this.btnZGraph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.Location = new System.Drawing.Point(538, 458);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(126, 62);
            this.btnZGraph.TabIndex = 3;
            this.btnZGraph.Text = "Z Graph Example";
            this.btnZGraph.UseVisualStyleBackColor = true;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // btnRemoveNoise
            // 
            this.btnRemoveNoise.Location = new System.Drawing.Point(295, 492);
            this.btnRemoveNoise.Name = "btnRemoveNoise";
            this.btnRemoveNoise.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveNoise.TabIndex = 6;
            this.btnRemoveNoise.Text = "Remove Noise";
            this.btnRemoveNoise.UseVisualStyleBackColor = true;
            this.btnRemoveNoise.Click += new System.EventHandler(this.button1_Click);
            // 
            // numWindowSize
            // 
            this.numWindowSize.Location = new System.Drawing.Point(296, 469);
            this.numWindowSize.Name = "numWindowSize";
            this.numWindowSize.Size = new System.Drawing.Size(36, 20);
            this.numWindowSize.TabIndex = 8;
            this.numWindowSize.Tag = "";
            this.numWindowSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWindowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numTrimValue
            // 
            this.numTrimValue.Location = new System.Drawing.Point(345, 469);
            this.numTrimValue.Name = "numTrimValue";
            this.numTrimValue.Size = new System.Drawing.Size(36, 20);
            this.numTrimValue.TabIndex = 9;
            this.numTrimValue.Tag = "";
            this.numTrimValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTrimValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 527);
            this.Controls.Add(this.numTrimValue);
            this.Controls.Add(this.numWindowSize);
            this.Controls.Add(this.btnRemoveNoise);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Image Filters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.Button btnRemoveNoise;
        private System.Windows.Forms.NumericUpDown numWindowSize;
        private System.Windows.Forms.NumericUpDown numTrimValue;
    }
}

