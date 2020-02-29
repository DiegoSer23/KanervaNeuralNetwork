using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanervaNN
{
    public partial class Form1 : Form
    {
        private int[,] randMatrix = new int[50, 25];
        private int[,] weightMatrix = new int[50, 25];
        private int[] hammingVector = new int[50];
        public Form1()
        {
            InitializeComponent();
            generateMatrix();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            int[] vectorA = new int[25];
            int[] vectorB = new int[25];
            short count = 0;
            // First we retrieve the vectors either autoassociative or heteroassociative
            foreach (Control cont in panelA.Controls)
            {
                if (cont.BackColor == Color.Black)
                    vectorA[count] = 1;
                count++;
            }
            count = 0;
            foreach (Control cont in panelB.Controls)
            {
                if (cont.BackColor == Color.Black)
                    vectorB[count] = 1;
                count++;
            }
            // Find Hamming distances on first matrix
            getHammingDistances(vectorA);
            // Call function and copy pattern on new matrix comparing with other pattern
            setWeightMatrix(vectorB);
            foreach (Control cont in panelA.Controls)
                cont.BackColor = Color.White;
            foreach (Control cont in panelB.Controls)
                cont.BackColor = Color.White;
        }

        private void generateMatrix()
        {
            Random rand = new Random();
            // Fill matrix with random ones and zeroes
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    this.randMatrix[i, j] = rand.Next(0, 2);
                }
            }
        }

        private void getHammingDistances(int[] firstVector)
        {
            int sum = 0;
            // Compare all binary strings and sum the difference
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (firstVector[j] != this.randMatrix[i, j])
                        sum++;
                }
                this.hammingVector[i] = sum;
                sum = 0;
            }
        }

        private void setWeightMatrix(int[] secondVector)
        {
            // Compare hamming vector to threshold and copy pattern (sum if necessary)
            for (int i = 0; i < 50; i++)
            {
                if (this.hammingVector[i] <= 10)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        if (secondVector[j] == 0)
                            this.weightMatrix[i, j] += -1;
                        else
                            this.weightMatrix[i, j] += 1;
                    }
                }
                this.hammingVector[i] = 0;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int[] inputVector = new int[25];
            int[] outputVector = new int[25];
            short count = 0;
            // First we read pattern to recognize
            foreach (Control cont in panelInput.Controls)
            {
                if (cont.BackColor == Color.Black)
                    inputVector[count] = 1;
                count++;
            }
            // We calculate hamming distances with this function
            getHammingDistances(inputVector);
            // Call function for the sum of patterns and getting output vector
            outputVector = getOutputVector();
            // Print pattern
            count = 0;
            foreach (Control cont in panelOutput.Controls)
            {
                if (outputVector[count] == 1)
                    cont.BackColor = Color.Black;
                count++;
            }
        }

        private int[] getOutputVector()
        {
            int[] vectorOut = new int[25];
            // We select the passed patterns and sum the whole column
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (this.hammingVector[i] <= 10)
                        vectorOut[j] += this.weightMatrix[i, j];
                }
            }
            // Convert vector to 1 and 0 with threshold
            for (int i = 0; i < 25; i++)
            {
                if (vectorOut[i] > 0)
                    vectorOut[i] = 1;
                else
                    vectorOut[i] = 0;
            }
            return vectorOut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control cont in panelInput.Controls)
                cont.BackColor = Color.White;
            foreach (Control cont in panelOutput.Controls)
                cont.BackColor = Color.White;
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            btnX1.BackColor = Color.Black;
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            btnX2.BackColor = Color.Black;
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            btnX3.BackColor = Color.Black;
        }

        private void btnX4_Click(object sender, EventArgs e)
        {
            btnX4.BackColor = Color.Black;
        }

        private void btnX5_Click(object sender, EventArgs e)
        {
            btnX5.BackColor = Color.Black;
        }

        private void btnX6_Click(object sender, EventArgs e)
        {
            btnX6.BackColor = Color.Black;
        }

        private void btnX7_Click(object sender, EventArgs e)
        {
            btnX7.BackColor = Color.Black;
        }

        private void btnX8_Click(object sender, EventArgs e)
        {
            btnX8.BackColor = Color.Black;
        }

        private void btnX9_Click(object sender, EventArgs e)
        {
            btnX9.BackColor = Color.Black;
        }

        private void btnX10_Click(object sender, EventArgs e)
        {
            btnX10.BackColor = Color.Black;
        }

        private void btnX11_Click(object sender, EventArgs e)
        {
            btnX11.BackColor = Color.Black;
        }

        private void btnX12_Click(object sender, EventArgs e)
        {
            btnX12.BackColor = Color.Black;
        }

        private void btnX13_Click(object sender, EventArgs e)
        {
            btnX13.BackColor = Color.Black;
        }

        private void btnX14_Click(object sender, EventArgs e)
        {
            btnX14.BackColor = Color.Black;
        }

        private void btnX15_Click(object sender, EventArgs e)
        {
            btnX15.BackColor = Color.Black;
        }

        private void btnX16_Click(object sender, EventArgs e)
        {
            btnX16.BackColor = Color.Black;
        }

        private void btnX17_Click(object sender, EventArgs e)
        {
            btnX17.BackColor = Color.Black;
        }

        private void btnX18_Click(object sender, EventArgs e)
        {
            btnX18.BackColor = Color.Black;
        }

        private void btnX19_Click(object sender, EventArgs e)
        {
            btnX19.BackColor = Color.Black;
        }

        private void btnX20_Click(object sender, EventArgs e)
        {
            btnX20.BackColor = Color.Black;
        }

        private void btnX21_Click(object sender, EventArgs e)
        {
            btnX21.BackColor = Color.Black;
        }

        private void btnX22_Click(object sender, EventArgs e)
        {
            btnX22.BackColor = Color.Black;
        }

        private void btnX23_Click(object sender, EventArgs e)
        {
            btnX23.BackColor = Color.Black;
        }

        private void btnX24_Click(object sender, EventArgs e)
        {
            btnX24.BackColor = Color.Black;
        }

        private void btnX25_Click(object sender, EventArgs e)
        {
            btnX25.BackColor = Color.Black;
        }

        private void btnW1_Click(object sender, EventArgs e)
        {
            btnW1.BackColor = Color.Black;
        }

        private void btnW2_Click(object sender, EventArgs e)
        {
            btnW2.BackColor = Color.Black;
        }

        private void btnW3_Click(object sender, EventArgs e)
        {
            btnW3.BackColor = Color.Black;
        }

        private void btnW4_Click(object sender, EventArgs e)
        {
            btnW4.BackColor = Color.Black;
        }

        private void btnW5_Click(object sender, EventArgs e)
        {
            btnW5.BackColor = Color.Black;
        }

        private void btnW6_Click(object sender, EventArgs e)
        {
            btnW6.BackColor = Color.Black;
        }

        private void btnW7_Click(object sender, EventArgs e)
        {
            btnW7.BackColor = Color.Black;
        }

        private void btnW8_Click(object sender, EventArgs e)
        {
            btnW8.BackColor = Color.Black;
        }

        private void btnW9_Click(object sender, EventArgs e)
        {
            btnW9.BackColor = Color.Black;
        }

        private void btnW10_Click(object sender, EventArgs e)
        {
            btnW10.BackColor = Color.Black;
        }

        private void btnW11_Click(object sender, EventArgs e)
        {
            btnW11.BackColor = Color.Black;
        }

        private void btnW12_Click(object sender, EventArgs e)
        {
            btnW12.BackColor = Color.Black;
        }

        private void btnW13_Click(object sender, EventArgs e)
        {
            btnW13.BackColor = Color.Black;
        }

        private void btnW14_Click(object sender, EventArgs e)
        {
            btnW14.BackColor = Color.Black;
        }

        private void btnW15_Click(object sender, EventArgs e)
        {
            btnW15.BackColor = Color.Black;
        }

        private void btnW16_Click(object sender, EventArgs e)
        {
            btnW16.BackColor = Color.Black;
        }

        private void btnW17_Click(object sender, EventArgs e)
        {
            btnW17.BackColor = Color.Black;
        }

        private void btnW18_Click(object sender, EventArgs e)
        {
            btnW18.BackColor = Color.Black;
        }

        private void btnW19_Click(object sender, EventArgs e)
        {
            btnW19.BackColor = Color.Black;
        }

        private void btnW20_Click(object sender, EventArgs e)
        {
            btnW20.BackColor = Color.Black;
        }

        private void btnW21_Click(object sender, EventArgs e)
        {
            btnW21.BackColor = Color.Black;
        }

        private void btnW22_Click(object sender, EventArgs e)
        {
            btnW22.BackColor = Color.Black;
        }

        private void btnW23_Click(object sender, EventArgs e)
        {
            btnW23.BackColor = Color.Black;
        }

        private void btnW24_Click(object sender, EventArgs e)
        {
            btnW24.BackColor = Color.Black;
        }

        private void btnW25_Click(object sender, EventArgs e)
        {
            btnW25.BackColor = Color.Black;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            btnSearch1.BackColor = Color.Black;
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            btnSearch2.BackColor = Color.Black;
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            btnSearch3.BackColor = Color.Black;
        }

        private void btnSearch4_Click(object sender, EventArgs e)
        {
            btnSearch4.BackColor = Color.Black;
        }

        private void btnSearch5_Click(object sender, EventArgs e)
        {
            btnSearch5.BackColor = Color.Black;
        }

        private void btnSearch6_Click(object sender, EventArgs e)
        {
            btnSearch6.BackColor = Color.Black;
        }

        private void btnSearch7_Click(object sender, EventArgs e)
        {
            btnSearch7.BackColor = Color.Black;
        }

        private void btnSearch8_Click(object sender, EventArgs e)
        {
            btnSearch8.BackColor = Color.Black;
        }

        private void btnSearch9_Click(object sender, EventArgs e)
        {
            btnSearch9.BackColor = Color.Black;
        }

        private void btnSearch10_Click(object sender, EventArgs e)
        {
            btnSearch10.BackColor = Color.Black;
        }

        private void btnSearch11_Click(object sender, EventArgs e)
        {
            btnSearch11.BackColor = Color.Black;
        }

        private void btnSearch12_Click(object sender, EventArgs e)
        {
            btnSearch12.BackColor = Color.Black;
        }

        private void btnSearch13_Click(object sender, EventArgs e)
        {
            btnSearch13.BackColor = Color.Black;
        }

        private void btnSearch14_Click(object sender, EventArgs e)
        {
            btnSearch14.BackColor = Color.Black;
        }

        private void btnSearch15_Click(object sender, EventArgs e)
        {
            btnSearch15.BackColor = Color.Black;
        }

        private void btnSearch16_Click(object sender, EventArgs e)
        {
            btnSearch16.BackColor = Color.Black;
        }

        private void btnSearch17_Click(object sender, EventArgs e)
        {
            btnSearch17.BackColor = Color.Black;
        }

        private void btnSearch18_Click(object sender, EventArgs e)
        {
            btnSearch18.BackColor = Color.Black;
        }

        private void btnSearch19_Click(object sender, EventArgs e)
        {
            btnSearch19.BackColor = Color.Black;
        }

        private void btnSearch20_Click(object sender, EventArgs e)
        {
            btnSearch20.BackColor = Color.Black;
        }

        private void btnSearch21_Click(object sender, EventArgs e)
        {
            btnSearch21.BackColor = Color.Black;
        }

        private void btnSearch22_Click(object sender, EventArgs e)
        {
            btnSearch22.BackColor = Color.Black;
        }

        private void btnSearch23_Click(object sender, EventArgs e)
        {
            btnSearch23.BackColor = Color.Black;
        }

        private void btnSearch24_Click(object sender, EventArgs e)
        {
            btnSearch24.BackColor = Color.Black;
        }

        private void btnSearch25_Click(object sender, EventArgs e)
        {
            btnSearch25.BackColor = Color.Black;
        }
    }
}