using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord;
using Accord.Imaging;
using System.Drawing.Imaging;
using Accord.Imaging.Filters;

namespace Project_TamplateM
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        //Przycisk Select Image
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //Formaty obrazów 
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Jpeg|*.jpg";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        PictureInput.Image = new Bitmap(dlg.FileName);
                        textBox1.Text = dlg.FileName;
                        

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.ToString());
            }



        }

        //Otwieranie drugiego obrazku
        private void btnTamplate_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Jpeg|*.jpg";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        PicTemplate.Image = new Bitmap(dlg.FileName);
                        textBox2.Text = dlg.FileName;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception" + ex.ToString());
            }
               
        }

        

        private void btnMatch_Click(object sender, EventArgs e)
        {
            //Przyswojenie bitmapy
            Bitmap templateImage = new Bitmap(PicTemplate.Image);
            Grayscale gg = new GrayscaleBT709();
            //Converting Template into GrayScale Image            
            Bitmap grayTemplate = gg.Apply(templateImage);

            //Wyłowanie algorytmu tamplate mathicng
            // create template matching algorithm's instance
            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0);
            
            //Przyswojenie drugiego obrazku
            Bitmap sourceImage = new Bitmap(PictureInput.Image);
            Bitmap graySource = gg.Apply(sourceImage);

            // find all matchings with specified above similarity
            TemplateMatch[] matchings = tm.ProcessImage(graySource, grayTemplate);
            lbRes.Text = "Result:";
            
            Graphics g = Graphics.FromImage(sourceImage);
            if (matchings[0].Similarity > 0.8f)
            {
                int X = matchings[0].Rectangle.X;
                int Y = matchings[0].Rectangle.Y;
                //ramka dla poszukiwanego objektu
                g.DrawRectangle(new Pen(Color.Red, 3), X, Y, matchings[0].Rectangle.Width, matchings[0].Rectangle.Height);
                //Show Original
                PicTemplate.Image = sourceImage;
                //Pokaz modal okienko
                MessageBox.Show("Match found...");
            }
            else
            {
                MessageBox.Show("Match Not Found...");
            }
        }

        //Btn Event Informacja
        private void info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.NewLine + "Project: Numer 21 -> Tamlate Matching" +
           Environment.NewLine + "Tworca: Roman Uliashyn. Nr. albumu 16536"
           + Environment.NewLine
           + Environment.NewLine
           + Environment.NewLine + "Wykladowcy: Marek Doros , Anna Korzyńska , Łukasz Roszkowiak"
           + Environment.NewLine + "Przedmiot: Algorytmy Przetwarzania Obrazów");


        }
    }
}
