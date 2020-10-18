using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HotelReservation
{
    public class Guest
    {
        public int TransactionNumber{ get; set; }
        public string FirstName { get; set; }
        public char MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string RoomType { get; set; }
        public int RoomPrice { get; set; }
        public int NoAdult { get; set; }
        public int NoChildren { get; set; }
        public int NoDays { get; set; }
        
        

        public Guest()
        {
            TransactionNumber = 0;
            FirstName = "Nothing";
            MiddleInitial = 'x';
            LastName = "Nothing";
            RoomType = "Nothing";
            RoomPrice = 0;
            NoAdult = 0;
            NoChildren = 0;
            NoDays = 0;
         
        }

        public decimal TotalAmount(int adult, int children, int room, int day)
        {
            decimal room_price = room * day;
            decimal adult_price = room_price *( 0.025m * adult);
            decimal child_price = room_price * ( 0.013m * children);

            decimal total = room_price + adult_price + child_price;
            return total;

        } 

        public int Generator()
        {
            Random random = new Random();
            int trans = random.Next(100000);
            return trans;
        }

        public void Writer()
        {
           

        }
    }
}
