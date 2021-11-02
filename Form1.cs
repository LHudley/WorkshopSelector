using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string selectedWorkshop;
        string selectedCity;
        int numOfDays;
        decimal registration;
        decimal lodging;
        decimal fee;
        decimal total;

        private void btBooking_Click(object sender, EventArgs e)
        {
           
           

            lblRegistration.Visible = true;
            lblLodging.Visible = true;
            lblTotal.Visible = true;
            lblNumOfDays.Visible = true;



            if (listBox1.SelectedIndex != -1)
            {
                selectedWorkshop = listBox1.SelectedItem.ToString();



                switch (selectedWorkshop)
                {
                    case "Handling Stress":
                        label8.Text = "3 Days";
                        label4.Text = "$1000";
                        numOfDays = 3;
                        registration = 1000m;
                        break;
                    case "Time Management":
                        label8.Text = "3 Days";
                        label4.Text = "$800";
                        numOfDays = 3;
                        registration = 800m;
                        break;
                    case "Supervision Skills":
                        label8.Text = "3 Days";
                        label4.Text = "$1500";
                        numOfDays = 3;
                        registration = 1500m;
                        break;
                    case "Negotiation":
                        label8.Text = "5 Days";
                        label4.Text = "$1300";
                        numOfDays = 5;
                        registration = 1300m;
                        break;
                    case "How to Interview":
                        label8.Text = "1 Days";
                        label4.Text = "$500";
                        numOfDays = 1;
                        registration = 500m;
                        break;

                }
            }
            else
            {
                MessageBox.Show("No selected items");
            }


            if (listBox2.SelectedIndex != -1)
            {
                selectedCity = listBox2.SelectedItem.ToString();


                switch (selectedCity)
                {
                    case "Austin":
                        lodging = 150m;
                        break;
                    case "Chicago":
                        lodging = 225m; ;
                        break;
                    case "Dallas":
                        lodging = 175m;
                        break;
                    case "Orlando":
                        lodging = 300m;
                        break;
                    case "Phoenix":
                        lodging = 175m;
                        break;
                    case "Raleigh":
                        lodging = 150m;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No selected items");
            }

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            fee = lodging * numOfDays;
            total = fee + registration;
            label5.Text = fee.ToString("c");
            label6.Text = total.ToString("c");
                

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           


            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";

            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
