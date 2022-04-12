using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentProject;
using TournamentProject.DataAccess;
using TournamentProject.Models;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        IPrizeRequestor CallingForm;

        public CreatePrize(IPrizeRequestor Caller)
        {
            InitializeComponent();
            CallingForm = Caller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrizeAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrize_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePrizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeClickButton(object sender, EventArgs e)
        {
            if(ValidateForm())
            { // when the form is validated we save the info then clear it
                  PrizeModel model = new PrizeModel(PlaceNameTextBox.Text, placeNumberTextBox.Text,
                                                    PrizeAmountTextBox.Text, PrizePercentageTextBox.Text);

                
             GlobalConfig.Connection.CreatePrize(model); // save the form

                CallingForm.PrizeComplete(model); 
                this.Close();
                
                //PlaceNameTextBox.Text = " "; // clear the form 
                //placeNumberTextBox.Text = " ";
                //PrizeAmountTextBox.Text = "0";
                //PrizePercentageTextBox.Text = "0";
                
            }
            else
            {
                MessageBox.Show("This Form has invalid information, please try again");
            }


        }
        private bool ValidateForm()
        { // to check the info writen and validate them 
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (placeNumberValidNumber == false )
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(PlaceNameTextBox.Text.Length ==0)
            {
                output = false;    
            }

            decimal PrizeAmount = 0;
            double PrizePercentage = 0;
            bool PrizeAmountValid = decimal.TryParse(PrizeAmountTextBox.Text, out PrizeAmount);
            bool PrizePercentageValidNumber = double.TryParse(PrizePercentageTextBox.Text,out PrizePercentage);

            if (PrizeAmountValid == false || PrizePercentageValidNumber == false)
            {
                output = false;

            }
            if (PrizeAmount <= 0 && PrizePercentage <= 0)
            {
                output = false;
            }

            if(PrizePercentage < 0 || PrizePercentage > 100)
            {
                output = false;
            }


            return output;

        }

        private void PlaceNumberLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
