using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics wormGraphics;
        private Brush brush0, brush1, brush2, brush3, brush4, brush5, brush6, brush7, brush8, brush9, brush10;
        private Worm[,] arrayWorm = new Worm[100, 50];
        private Boolean activeGame = false;
        private int blockSize = 5;
        private int step = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    arrayWorm[i, j] = new Worm(i, j);
                }
            }

            wormGraphics = wormsPanel.CreateGraphics();

            brush0 = new SolidBrush(Color.LightCyan);
            brush1 = new SolidBrush(Color.SpringGreen);
            brush2 = new SolidBrush(Color.LightGreen);
            brush3 = new SolidBrush(Color.Green);
            brush4 = new SolidBrush(Color.DarkGreen);
            brush5 = new SolidBrush(Color.DarkKhaki);
            brush6 = new SolidBrush(Color.LightGray);
            brush7 = new SolidBrush(Color.Gray);
            brush8 = new SolidBrush(Color.DarkGray);
            brush9 = new SolidBrush(Color.DarkSlateGray);
            brush10 = new SolidBrush(Color.DarkTurquoise);

            ResetWorms(arrayWorm);
            Render(arrayWorm);
        }

        private void randomValueBar_Scroll(object sender, EventArgs e)
        {
            seedsValue.Text = randomValueBar.Value.ToString();
        }

        private void Render(Worm[,] worm)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (worm[i, j].isAlive())
                    {
                        switch (worm[i, j].getAge())
                        {
                            case 0:
                                wormGraphics.FillRectangle(brush0, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 1:
                                wormGraphics.FillRectangle(brush1, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 2:
                                wormGraphics.FillRectangle(brush2, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 3:
                                wormGraphics.FillRectangle(brush3, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 4:
                                wormGraphics.FillRectangle(brush4, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 5:
                                wormGraphics.FillRectangle(brush5, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 6:
                                wormGraphics.FillRectangle(brush6, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 7:
                                wormGraphics.FillRectangle(brush7, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            case 8:
                                wormGraphics.FillRectangle(brush8, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;

                            default:
                                wormGraphics.FillRectangle(brush9, i * blockSize, j * blockSize, blockSize, blockSize);
                                break;
                        }
                    }
                    else
                    {
                        wormGraphics.FillRectangle(brush10, i * blockSize, j * blockSize, blockSize, blockSize);
                    }
                }
            }

            WormsDeadLabel.Text = this.getDeadWormsCount(arrayWorm).ToString();
            wormsAliveLabel.Text = this.getAliveWormsCount(arrayWorm).ToString();
        }

        private void setAliveness(Worm[,] worm)
        {
            int neighboursMin, neighboursMax, ageMax, DeadtimeMax;
            neighboursMin = int.Parse(aliveNeighboursMinInput.Text);
            neighboursMax = int.Parse(aliveNeighboursMaxInput.Text);
            ageMax = int.Parse(ageMaxInput.Text);
            DeadtimeMax = int.Parse(deadtimeMaxInput.Text);

            for (int i = 1; i < 99; i++)
            {
                for (int j = 1; j < 49; j++)
                {
                    worm[i, j].evaluateLife(worm, neighboursMin, neighboursMax, ageMax, DeadtimeMax);
                }
            }
        }

        private int getAliveWormsCount(Worm[,] worm)
        {
            int count = 0;

            for (int i = 1; i < 99; i++)
            {
                for (int j = 1; j < 49; j++)
                {
                    if (worm[i, j].isAlive()) count++;
                }
            }

            return count;
        }

        private int getDeadWormsCount(Worm[,] worm)
        {
            int count = 0;

            for (int i = 1; i < 99; i++)
            {
                for (int j = 1; j < 49; j++)
                {
                    if (!worm[i, j].isAlive()) count++;
                }
            }

            return count;
        }

        private void ResetWorms(Worm[,] worm)
        {
            Random random = new Random();

            int randomValue = randomValueBar.Value;

            for (int i = 1; i < 99; i++)
            {
                for (int j = 1; j < 49; j++)
                {
                    worm[i, j].setDead();

                    if (random.Next(0, 100) > 100 - randomValue) worm[i, j].setAlive();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setAliveness(arrayWorm);

            if (activeGame)
            {
                this.Render(arrayWorm);
                step++;
                stepLabel.Text = step.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetWorms(arrayWorm);
            step = 0;
            Render(arrayWorm);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            activeGame = !activeGame;
            if (buttonStart.Text == "Start")
            {
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
            }
        }
    }
}