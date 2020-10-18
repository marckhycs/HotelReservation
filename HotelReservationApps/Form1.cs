using HotelReservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationApps
{
    public partial class Form1 : Form
    {
        public int roomPrice;
        public string roomType;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radio_Single_CheckedChanged(object sender, EventArgs e)
        {
            Guest room = new Guest();
            roomType = "Single";
            lbl_RoomPrice.Text= "Php 1,500.00";
            roomPrice = 1500;
        }

        private void radio_Master_CheckedChanged(object sender, EventArgs e)
        {
            Guest room = new Guest();
            roomType = "Master";
            lbl_RoomPrice.Text = "Php 3,500.00";
            roomPrice = 3500;
        }

        private void radio_Family_CheckedChanged(object sender, EventArgs e)
        {
            Guest room = new Guest();
            roomType = "Family";
            roomPrice = 5000;
            lbl_RoomPrice.Text = "Php 5,000.00";
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            try
            {
                Guest room = new Guest();
                int adult = int.Parse(txt_Adult.Text);
                int children = int.Parse(txt_Children.Text);
                int days = int.Parse(txt_Days.Text);
                decimal total = room.TotalAmount(adult, children, roomPrice, days);
                txt_TransactionID.Text = room.Generator().ToString();

                lbl_TotalAmount.Text = $"Php {total}";
                
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }

        private void txt_TransactionID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TransactionID.TextLength > 0 && txt_LastName.TextLength>0 && txt_FirstName.TextLength>0 && txt_MiddleInitial.TextLength > 0)
                {
                   
                    StreamWriter sw = new StreamWriter("../../guest.txt", true);
                    sw.WriteLine($"{txt_TransactionID.Text}     {txt_LastName.Text}     {txt_FirstName.Text}     {txt_MiddleInitial.Text}     {roomType}     {lbl_TotalAmount.Text}");
                    sw.Close();
                    MessageBox.Show("Data was save successfully", "Alert");
                }
                else
                {
                    MessageBox.Show("Please complete the forms.");
                }
            }
            catch
            {

                MessageBox.Show("Error occur while saving your data....");
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_TransactionID.Text = "";
            txt_LastName.Text = "";
            txt_FirstName.Text = "";
            txt_MiddleInitial.Text = "";
            roomType = "";
            roomPrice = 0;
            txt_Adult.Text = "";
            txt_Children.Text = "";
            txt_Days.Text = "";
            lbl_RoomPrice.Text = "No room is selected";
            lbl_TotalAmount.Text = "Php 0.00";
            

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string code = txt_TransactionID.Text;
            StreamReader sr = new StreamReader("../../guest.txt");
            string line = sr.ReadLine();
            while(line != null)
            {
                if (line.Contains(code))
                {
                    MessageBox.Show($"{line}");
                    break;
                }
                else
                {
                    line = sr.ReadLine();
                }
                if (line == null)
                {
                    MessageBox.Show("Customer record does not exits in our database.");
                }
            }
            sr.Close();
            
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
