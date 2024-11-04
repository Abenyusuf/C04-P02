// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 02 Chapter 04)
// Description of the Program: This program will use the input of the loaction and workshop the user request and calculate the total cost of the work shop 
// Extra credit was also completed using radio buttons





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace C04_P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // This will close the form if the button is clicked
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double Handling_Stress, Time_Management, Supervision_Skills, Negotiation, How_to_Interview;
            double Austin, Chicago, Dallas, Orlando, Phoenix, Raleigh;
            double Total1 = 0, Total2 = 0, days = 0;

            // This will give a value to the location doubles to represent costs
            Austin = 150; // $
            Chicago = 225; // $
            Dallas = 175; // $
            Orlando = 300; // $
            Phoenix = 175; // $
            Raleigh = 150; // $

            // This will give a value to the workshop doubles to represent costs
            Handling_Stress = 1000; // $
            Time_Management = 800; // $
            Supervision_Skills = 1500; // $
            Negotiation = 1300; // $
            How_to_Interview = 500; // $

            // This will give a value to the amount of days a specific Workshop will take using doubles
            double Handling_Stress_days = 3;
            double Time_Management_days = 3;
            double Supervision_Skills_days = 3;
            double Negotiation_days = 5;
            double How_to_Interview_days = 1;

            // this will retrieve the selected workshop
            string selectedWorkshop = WorkshopListbox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedWorkshop))
            {
                // If no workshop is chosen this will display
                OutputLabel.Text = "Please select a workshop";
                return;
            }

            // Switch based on the selected workshop
            switch (selectedWorkshop)
            {
                // These are all of the following cases for the possible choices
                case "Handling Stress":
                    Total1 = Handling_Stress;
                    days = Handling_Stress_days;
                    break;
                case "Time Management":
                    Total1 = Time_Management;
                    days = Time_Management_days;
                    break;
                case "Supervision Skills":
                    Total1 = Supervision_Skills;
                    days = Supervision_Skills_days;
                    break;
                case "Negotiation":
                    Total1 = Negotiation;
                    days = Negotiation_days;
                    break;
                case "How to Interview":
                    Total1 = How_to_Interview;
                    days = How_to_Interview_days;
                    break;
            }

            // This will retrieve the selected location
            string SelectedLocation = LocationListbox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(SelectedLocation))
            {
                // If no location is chosen this will display
                OutputLabel.Text = "Please select a location";
                return;
            }

            // Switch based on the selected location
            switch (SelectedLocation)
            {
                // These are all of the following cases for the possible choices
                case "Austin":
                    Total2 = Austin;
                    break;
                case "Chicago":
                    Total2 = Chicago;
                    break;
                case "Dallas":
                    Total2 = Dallas;
                    break;
                case "Orlando":
                    Total2 = Orlando;
                    break;
                case "Phoenix":
                    Total2 = Phoenix;
                    break;
                case "Raleigh":
                    Total2 = Raleigh;
                    break;
            }
            // This will check to see if the on of the radio buttons are selected
            if (FivePercentButton.Checked)
                // Based off of the choice of radio button selected this will display what percentage of discount the user will recieve
                DiscountLabel.Text = ("5%");
            else if (TenPercentButton.Checked)
                DiscountLabel.Text = ("10%");
            else if (FifteenPercentButton.Checked)
                DiscountLabel.Text = ("15%");
            // If no button is selected this will display no discount
            else 
                DiscountLabel.Text = ("No Discount");
                { 
            }

            // Calculate the result based on the selected workshop and location
            double result = (Total1 * days) + Total2;

            // This will display the final result as a currency
            OutputLabel.Text = result.ToString("C");
        }
    }
}