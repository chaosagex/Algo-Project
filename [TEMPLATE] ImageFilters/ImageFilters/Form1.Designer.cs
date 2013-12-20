namespace ImageFilters
{
    partial class mainForm
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
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.btnRemoveNoise_Alpha = new System.Windows.Forms.Button();
            this.numWindowSize_Alpha = new System.Windows.Forms.NumericUpDown();
            this.numTrimValue_Alpha = new System.Windows.Forms.NumericUpDown();
            this.grpbxAlphaTrim = new System.Windows.Forms.GroupBox();
            this.lblWindowSize_Alpha = new System.Windows.Forms.Label();
            this.lblTrimValue_Alpha = new System.Windows.Forms.Label();
            this.grpbxSortingType_Alpha = new System.Windows.Forms.GroupBox();
            this.rdCountingSort_Alpha = new System.Windows.Forms.RadioButton();
            this.rdKthSort_Alpha = new System.Windows.Forms.RadioButton();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.grpbxAdaptiveMedian = new System.Windows.Forms.GroupBox();
            this.grpbxSortingType_Median = new System.Windows.Forms.GroupBox();
            this.rdQuickSort_Median = new System.Windows.Forms.RadioButton();
            this.rdCountingSort_Median = new System.Windows.Forms.RadioButton();
            this.lblWindowSize_Median = new System.Windows.Forms.Label();
            this.btnRemoveNoise_Median = new System.Windows.Forms.Button();
            this.numWindowSize_Median = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize_Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimValue_Alpha)).BeginInit();
            this.grpbxAlphaTrim.SuspendLayout();
            this.grpbxSortingType_Alpha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.grpbxAdaptiveMedian.SuspendLayout();
            this.grpbxSortingType_Median.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize_Median)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.Location = new System.Drawing.Point(12, 12);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(436, 409);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.Click += new System.EventHandler(this.leftPictureBox_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(394, 461);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnZGraph
            // 
            this.btnZGraph.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.Location = new System.Drawing.Point(394, 529);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(126, 30);
            this.btnZGraph.TabIndex = 3;
            this.btnZGraph.Text = "Z Graph";
            this.btnZGraph.UseVisualStyleBackColor = true;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // btnRemoveNoise_Alpha
            // 
            this.btnRemoveNoise_Alpha.Location = new System.Drawing.Point(88, 123);
            this.btnRemoveNoise_Alpha.Name = "btnRemoveNoise_Alpha";
            this.btnRemoveNoise_Alpha.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveNoise_Alpha.TabIndex = 6;
            this.btnRemoveNoise_Alpha.Text = "Remove Noise";
            this.btnRemoveNoise_Alpha.UseVisualStyleBackColor = true;
            this.btnRemoveNoise_Alpha.Click += new System.EventHandler(this.btnRemoveNoise_Alpha_Click);
            // 
            // numWindowSize_Alpha
            // 
            this.numWindowSize_Alpha.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWindowSize_Alpha.Location = new System.Drawing.Point(89, 100);
            this.numWindowSize_Alpha.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numWindowSize_Alpha.Name = "numWindowSize_Alpha";
            this.numWindowSize_Alpha.Size = new System.Drawing.Size(36, 20);
            this.numWindowSize_Alpha.TabIndex = 8;
            this.numWindowSize_Alpha.Tag = "";
            this.numWindowSize_Alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWindowSize_Alpha.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numTrimValue_Alpha
            // 
            this.numTrimValue_Alpha.Location = new System.Drawing.Point(138, 100);
            this.numTrimValue_Alpha.Name = "numTrimValue_Alpha";
            this.numTrimValue_Alpha.Size = new System.Drawing.Size(36, 20);
            this.numTrimValue_Alpha.TabIndex = 9;
            this.numTrimValue_Alpha.Tag = "";
            this.numTrimValue_Alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTrimValue_Alpha.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // grpbxAlphaTrim
            // 
            this.grpbxAlphaTrim.Controls.Add(this.grpbxSortingType_Alpha);
            this.grpbxAlphaTrim.Controls.Add(this.lblTrimValue_Alpha);
            this.grpbxAlphaTrim.Controls.Add(this.lblWindowSize_Alpha);
            this.grpbxAlphaTrim.Controls.Add(this.btnRemoveNoise_Alpha);
            this.grpbxAlphaTrim.Controls.Add(this.numTrimValue_Alpha);
            this.grpbxAlphaTrim.Controls.Add(this.numWindowSize_Alpha);
            this.grpbxAlphaTrim.Location = new System.Drawing.Point(12, 428);
            this.grpbxAlphaTrim.Name = "grpbxAlphaTrim";
            this.grpbxAlphaTrim.Size = new System.Drawing.Size(263, 156);
            this.grpbxAlphaTrim.TabIndex = 10;
            this.grpbxAlphaTrim.TabStop = false;
            this.grpbxAlphaTrim.Text = "Alpha-Trim";
            this.grpbxAlphaTrim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblWindowSize_Alpha
            // 
            this.lblWindowSize_Alpha.AutoSize = true;
            this.lblWindowSize_Alpha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblWindowSize_Alpha.Location = new System.Drawing.Point(17, 103);
            this.lblWindowSize_Alpha.Name = "lblWindowSize_Alpha";
            this.lblWindowSize_Alpha.Size = new System.Drawing.Size(69, 13);
            this.lblWindowSize_Alpha.TabIndex = 10;
            this.lblWindowSize_Alpha.Text = "Window Size";
            this.lblWindowSize_Alpha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrimValue_Alpha
            // 
            this.lblTrimValue_Alpha.AutoSize = true;
            this.lblTrimValue_Alpha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTrimValue_Alpha.Location = new System.Drawing.Point(177, 103);
            this.lblTrimValue_Alpha.Name = "lblTrimValue_Alpha";
            this.lblTrimValue_Alpha.Size = new System.Drawing.Size(57, 13);
            this.lblTrimValue_Alpha.TabIndex = 11;
            this.lblTrimValue_Alpha.Text = "Trim Value";
            this.lblTrimValue_Alpha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpbxSortingType_Alpha
            // 
            this.grpbxSortingType_Alpha.Controls.Add(this.rdKthSort_Alpha);
            this.grpbxSortingType_Alpha.Controls.Add(this.rdCountingSort_Alpha);
            this.grpbxSortingType_Alpha.Location = new System.Drawing.Point(64, 19);
            this.grpbxSortingType_Alpha.Name = "grpbxSortingType_Alpha";
            this.grpbxSortingType_Alpha.Size = new System.Drawing.Size(134, 71);
            this.grpbxSortingType_Alpha.TabIndex = 12;
            this.grpbxSortingType_Alpha.TabStop = false;
            this.grpbxSortingType_Alpha.Text = "Sorting Type";
            // 
            // rdCountingSort_Alpha
            // 
            this.rdCountingSort_Alpha.AutoSize = true;
            this.rdCountingSort_Alpha.Location = new System.Drawing.Point(25, 21);
            this.rdCountingSort_Alpha.Name = "rdCountingSort_Alpha";
            this.rdCountingSort_Alpha.Size = new System.Drawing.Size(89, 17);
            this.rdCountingSort_Alpha.TabIndex = 0;
            this.rdCountingSort_Alpha.Text = "Counting Sort";
            this.rdCountingSort_Alpha.UseVisualStyleBackColor = true;
            // 
            // rdKthSort_Alpha
            // 
            this.rdKthSort_Alpha.AutoSize = true;
            this.rdKthSort_Alpha.Checked = true;
            this.rdKthSort_Alpha.Location = new System.Drawing.Point(25, 40);
            this.rdKthSort_Alpha.Name = "rdKthSort_Alpha";
            this.rdKthSort_Alpha.Size = new System.Drawing.Size(82, 17);
            this.rdKthSort_Alpha.TabIndex = 1;
            this.rdKthSort_Alpha.TabStop = true;
            this.rdKthSort_Alpha.Text = "Kth Element";
            this.rdKthSort_Alpha.UseVisualStyleBackColor = true;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.Location = new System.Drawing.Point(466, 12);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(436, 409);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPictureBox.TabIndex = 11;
            this.rightPictureBox.TabStop = false;
            // 
            // grpbxAdaptiveMedian
            // 
            this.grpbxAdaptiveMedian.Controls.Add(this.grpbxSortingType_Median);
            this.grpbxAdaptiveMedian.Controls.Add(this.lblWindowSize_Median);
            this.grpbxAdaptiveMedian.Controls.Add(this.btnRemoveNoise_Median);
            this.grpbxAdaptiveMedian.Controls.Add(this.numWindowSize_Median);
            this.grpbxAdaptiveMedian.Location = new System.Drawing.Point(639, 428);
            this.grpbxAdaptiveMedian.Name = "grpbxAdaptiveMedian";
            this.grpbxAdaptiveMedian.Size = new System.Drawing.Size(263, 156);
            this.grpbxAdaptiveMedian.TabIndex = 13;
            this.grpbxAdaptiveMedian.TabStop = false;
            this.grpbxAdaptiveMedian.Text = "Adaptive Median";
            // 
            // grpbxSortingType_Median
            // 
            this.grpbxSortingType_Median.Controls.Add(this.rdQuickSort_Median);
            this.grpbxSortingType_Median.Controls.Add(this.rdCountingSort_Median);
            this.grpbxSortingType_Median.Location = new System.Drawing.Point(64, 19);
            this.grpbxSortingType_Median.Name = "grpbxSortingType_Median";
            this.grpbxSortingType_Median.Size = new System.Drawing.Size(134, 71);
            this.grpbxSortingType_Median.TabIndex = 12;
            this.grpbxSortingType_Median.TabStop = false;
            this.grpbxSortingType_Median.Text = "Sorting Type";
            // 
            // rdQuickSort_Median
            // 
            this.rdQuickSort_Median.AutoSize = true;
            this.rdQuickSort_Median.Checked = true;
            this.rdQuickSort_Median.Location = new System.Drawing.Point(25, 40);
            this.rdQuickSort_Median.Name = "rdQuickSort_Median";
            this.rdQuickSort_Median.Size = new System.Drawing.Size(75, 17);
            this.rdQuickSort_Median.TabIndex = 1;
            this.rdQuickSort_Median.TabStop = true;
            this.rdQuickSort_Median.Text = "Quick Sort";
            this.rdQuickSort_Median.UseVisualStyleBackColor = true;
            // 
            // rdCountingSort_Median
            // 
            this.rdCountingSort_Median.AutoSize = true;
            this.rdCountingSort_Median.Location = new System.Drawing.Point(25, 21);
            this.rdCountingSort_Median.Name = "rdCountingSort_Median";
            this.rdCountingSort_Median.Size = new System.Drawing.Size(89, 17);
            this.rdCountingSort_Median.TabIndex = 0;
            this.rdCountingSort_Median.Text = "Counting Sort";
            this.rdCountingSort_Median.UseVisualStyleBackColor = true;
            // 
            // lblWindowSize_Median
            // 
            this.lblWindowSize_Median.AutoSize = true;
            this.lblWindowSize_Median.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblWindowSize_Median.Location = new System.Drawing.Point(16, 103);
            this.lblWindowSize_Median.Name = "lblWindowSize_Median";
            this.lblWindowSize_Median.Size = new System.Drawing.Size(95, 13);
            this.lblWindowSize_Median.TabIndex = 10;
            this.lblWindowSize_Median.Text = "Max. Window Size";
            this.lblWindowSize_Median.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveNoise_Median
            // 
            this.btnRemoveNoise_Median.Location = new System.Drawing.Point(88, 123);
            this.btnRemoveNoise_Median.Name = "btnRemoveNoise_Median";
            this.btnRemoveNoise_Median.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveNoise_Median.TabIndex = 6;
            this.btnRemoveNoise_Median.Text = "Remove Noise";
            this.btnRemoveNoise_Median.UseVisualStyleBackColor = true;
            this.btnRemoveNoise_Median.Click += new System.EventHandler(this.btnRemoveNoise_Median_Click);
            // 
            // numWindowSize_Median
            // 
            this.numWindowSize_Median.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWindowSize_Median.Location = new System.Drawing.Point(114, 100);
            this.numWindowSize_Median.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numWindowSize_Median.Name = "numWindowSize_Median";
            this.numWindowSize_Median.Size = new System.Drawing.Size(36, 20);
            this.numWindowSize_Median.TabIndex = 8;
            this.numWindowSize_Median.Tag = "";
            this.numWindowSize_Median.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWindowSize_Median.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 595);
            this.Controls.Add(this.grpbxAdaptiveMedian);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.grpbxAlphaTrim);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.leftPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Image Filters";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize_Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimValue_Alpha)).EndInit();
            this.grpbxAlphaTrim.ResumeLayout(false);
            this.grpbxAlphaTrim.PerformLayout();
            this.grpbxSortingType_Alpha.ResumeLayout(false);
            this.grpbxSortingType_Alpha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.grpbxAdaptiveMedian.ResumeLayout(false);
            this.grpbxAdaptiveMedian.PerformLayout();
            this.grpbxSortingType_Median.ResumeLayout(false);
            this.grpbxSortingType_Median.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize_Median)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.Button btnRemoveNoise_Alpha;
        private System.Windows.Forms.NumericUpDown numWindowSize_Alpha;
        private System.Windows.Forms.NumericUpDown numTrimValue_Alpha;
        private System.Windows.Forms.GroupBox grpbxAlphaTrim;
        private System.Windows.Forms.GroupBox grpbxSortingType_Alpha;
        private System.Windows.Forms.Label lblTrimValue_Alpha;
        private System.Windows.Forms.Label lblWindowSize_Alpha;
        private System.Windows.Forms.RadioButton rdKthSort_Alpha;
        private System.Windows.Forms.RadioButton rdCountingSort_Alpha;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.GroupBox grpbxAdaptiveMedian;
        private System.Windows.Forms.GroupBox grpbxSortingType_Median;
        private System.Windows.Forms.RadioButton rdQuickSort_Median;
        private System.Windows.Forms.RadioButton rdCountingSort_Median;
        private System.Windows.Forms.Label lblWindowSize_Median;
        private System.Windows.Forms.Button btnRemoveNoise_Median;
        private System.Windows.Forms.NumericUpDown numWindowSize_Median;
    }
}

