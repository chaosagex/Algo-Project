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
            //int N = 40;
            //double[] x_values = new double[N];
            //double[] y_values_N = new double[N];
            //double[] y_values_NLogN = new double[N];

            //for (int i = 0; i < N; i++)
            //{
            //    x_values[i] = i;
            //    y_values_N[i] = i;
            //    y_values_NLogN[i] = i * Math.Log(i);
            //}

            //Create a graph and add two curves to it
            //ZGraphForm ZGF = new ZGraphForm("Sample Graph", "N", "f(N)");
            //ZGF.add_curve("f(N) = N", x_values, y_values_N, Color.Red);
            //ZGF.add_curve("f(N) = N Log(N)", x_values, y_values_NLogN, Color.Blue);
            //ZGF.Show();

            GraphType graphType;
            int wMax = (int)numMaxWindow_Graph.Value;

            if (cmbZGraph.SelectedIndex.Equals(0)){  //Alpha-Trim is choosen
                graphType = GraphType.ALPHA_TRIM;
            }
            else{
                graphType = GraphType.ADAPTIVE_MEDIAN;
            }
            
            DrawGraph.draw(wMax, graphType);
        }

        private void btnRemoveNoise_Alpha_Click(object sender, EventArgs e)
        {
            int windowSize = (int)numWindowSize_Alpha.Value;
            int trimValue  = (int)numTrimValue_Alpha.Value;

            if (ImageMatrix == null)
            {
                MessageBox.Show("Please choose an image first.", "No Input", MessageBoxButtons.OK);
            }
            else
            {
                SortingType sortingType;
                byte[,] filteredImage;
                AlphaTrimFilter alphaTrim = new AlphaTrimFilter(ImageMatrix);

                if (rdKthSort_Alpha.Checked)
                    sortingType = SortingType.KTH_ELEMENT;
                else if (rdCountingSort_Alpha.Checked)
                    sortingType = SortingType.COUNTING_SORT;
                else
                    sortingType = SortingType.BUILT_IN_SORT;

                filteredImage = alphaTrim.removeNoise(windowSize, trimValue, sortingType);

                if (filteredImage != null)  //No problem catched in 'removeNoise'.
                {
                    //Improving borders:
                    //filteredImage = ImageTools.initArray(filteredImage, windowSize);

                    //Final display:
                    ImageOperations.DisplayImage(filteredImage, rightPictureBox);
                }
            }
        }

        private void btnRemoveNoise_Median_Click(object sender, EventArgs e)
        {
            int windowMaxSize = (int)numWindowSize_Median.Value;
           

            if (ImageMatrix == null)
            {
                MessageBox.Show("Please choose an image first.", "No Input", MessageBoxButtons.OK);
            }
            else
            {
                SortingType sortingType;
                byte[,] filteredImage;
                AdaptiveMedianFilter adptvMdin = new AdaptiveMedianFilter(ImageMatrix, windowMaxSize);

                if (rdQuickSort_Median.Checked)
                    sortingType = SortingType.QUICK_SORT;
                else if (rdCountingSort_Median.Checked)
                    sortingType = SortingType.COUNTING_SORT;
                else
                    sortingType = SortingType.BUILT_IN_SORT;

                    adptvMdin.Filter(sortingType);
                    filteredImage = adptvMdin.getFilteredImage();

                if (filteredImage != null)  //No problem catched in 'removeNoise'.
                {
                    //Final display:
                    ImageOperations.DisplayImage(filteredImage, rightPictureBox);
                }
            }
        }

        private void rightPictureBox_Click(object sender, EventArgs e)
        {
            rightPictureBox.Image = null;
        }

        private void rightPictureBox_MouseHover(object sender, EventArgs e)
        {
            if (rightPictureBox.Image != null)
            {
                toolTip.Active = true;
                toolTip.SetToolTip(rightPictureBox, "Click to remove");
            }
            else
            {
                toolTip.Active = false;
            }
        }
    }
}
