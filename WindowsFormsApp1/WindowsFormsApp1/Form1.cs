using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<string> Products = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }        
        private void SetMaxPictureBoxPerRow(PictureBox currentPictureBox)
        {
            int pictureBoxWidth = currentPictureBox.Width;
            int panelWidth = checkBox1.Checked ? panel2.Width : panel1.Width;
            int maxPictureBoxPerRow = panelWidth / pictureBoxWidth;

            if (checkBox1.Checked && panel2.Controls.OfType<PictureBox>().Count() >= maxPictureBoxPerRow)
            {
                checkBox1.Checked = false;
            }
            else if (!checkBox1.Checked && panel1.Controls.OfType<PictureBox>().Count() >= maxPictureBoxPerRow)
            {
                checkBox1.Checked = true;
            }
        }
        private void SetPictureBoxLocation(PictureBox currentPictureBox, PictureBox lastPictureBox, Panel panel)
        {
            if (lastPictureBox != null)
            {
                currentPictureBox.Location = new Point(lastPictureBox.Right, lastPictureBox.Bottom - currentPictureBox.Height);

                if (panel.Width < currentPictureBox.Right || panel.Height < currentPictureBox.Bottom)
                {
                    currentPictureBox.Location = new Point((panel.Width - currentPictureBox.Width) / 2, (panel.Height - currentPictureBox.Height) / 2);
                }
            }
            else
            {
                currentPictureBox.Location = new Point(0, panel.Height - currentPictureBox.Height);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox2.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox2.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox3.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox3.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox4.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox4.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox5.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox5.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox6.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox6.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox7.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox7.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox8.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox8.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox9.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox9.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox10.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox10.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            bool panel1ContainsPictureBox = panel1.Controls.OfType<PictureBox>().Any();
            bool panel2ContainsPictureBox = panel2.Controls.OfType<PictureBox>().Any();

            if (!checkBox1.Checked)
            {
                if (panel1ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel1.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel1);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel1);
                }

                panel1.Controls.Add(clickedPictureBox);
                listBox1.Items.Add(pictureBox11.Tag);
            }
            else
            {
                if (panel2ContainsPictureBox)
                {
                    PictureBox lastPictureBox = panel2.Controls.OfType<PictureBox>().Last();
                    SetPictureBoxLocation(clickedPictureBox, lastPictureBox, panel2);
                }
                else
                {
                    SetPictureBoxLocation(clickedPictureBox, null, panel2);
                }

                panel2.Controls.Add(clickedPictureBox);
                listBox2.Items.Add(pictureBox11.Tag);
            }

            SetMaxPictureBoxPerRow(clickedPictureBox);
            Form1.Products.Add(clickedPictureBox.Tag.ToString());
            label8.Text = listBox1.Items.Count + " termék van a felső polcon";
            label9.Text = listBox2.Items.Count + " termék van a felső polcon";
        }                    
    }
}
