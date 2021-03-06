﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cat_DetectorML.Model;
namespace Cat_Detector
{
    public partial class catDogDetector : Form
    {
        public catDogDetector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pictureSelector = new OpenFileDialog())
            {
                pictureSelector.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                pictureSelector.ShowDialog();
                imagePathTb.Text=pictureSelector.FileName;
            }
            pictureHolder.ImageLocation = imagePathTb.Text;

        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var input = new ModelInput();
                input.ImageSource = imagePathTb.Text;
                ModelOutput result = ConsumeModel.Predict(input);
                float score = (result.Score[0] > result.Score[1] ? result.Score[0] : result.Score[1]);
                if (score<.8)
                {
                    statusRtb.Text = $"Neither Cat nor Dog";
                }
               else
                {
                    
                    statusRtb.Text =$"Predicted result: {result.Prediction} with a score {score}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
