using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZGraphTools;

namespace ImageFilters
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        byte[,] ImageMatrix;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, leftPictureBox);
            }
        }

        private void btnZGraph_Click(object sender, EventArgs e)
        {
            // Make up some data points from the N, N log(N) functions
            int N = 40;
            double[] x_values = new double[N];
            double[] y_values_N = new double[N];
            double[] y_values_NLogN = new double[N];

            for (int i = 0; i < N; i++)
            {
                x_values[i] = i;
                y_values_N[i] = i;
                y_values_NLogN[i] = i * Math.Log(i);
            }

            //Create a graph and add two curves to it
            ZGraphForm ZGF = new ZGraphForm("Sample Graph", "N", "f(N)");
            ZGF.add_curve("f(N) = N", x_values, y_values_N, Color.Red);
            ZGF.add_curve("f(N) = N Log(N)", x_values, y_values_NLogN, Color.Blue);
            ZGF.Show();
        }

        private void btnRemoveNoise_Alpha_Click(object sender, EventArgs e)
        {
            int windowSize = (int)numWindowSize_Alpha.Value;
            int trimValue  = (int)numTrimValue_Alpha.Value;

            if (ImageMatrix == null)
                MessageBox.Show("Please choose an image first.", "No Input", MessageBoxButtons.OK);
            else
            {
                SortingType sortingType;

                if (rdKthSort_Alpha.Checked)
                    sortingType = SortingType.KTH_ELEMENT;
                else if (rdCountingSort_Alpha.Checked)
                    sortingType = SortingType.COUNTING_SORT;
                else
                    sortingType = SortingType.BUILT_IN_SORT;

                AlphaTrimFilter alphaTrim = new AlphaTrimFilter(ImageMatrix, rightPictureBox, sortingType);
                alphaTrim.removeNoise(windowSize, trimValue);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void leftPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemoveNoise_Median_Click(object sender, EventArgs e)
        {

        }
    }
}
