using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;
namespace CheckOrderStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eid: 1111 Replace with your eid. You can find it in Billmate-Online
            //Secret: 111111111111 Replace with your secret. You can find it in Billmate-Online
            //SSL: false SSl should be enabled or not
            //Debug: true View more detailed information about the server communication
            //Order id: 111 View more detailed information about the server communication
            
            Console.WriteLine("Start");
            Billmate bm = new Billmate(1111, "111111111111", false, true);
            

            string result = (string)bm.CheckOrderStatus("111");

            if (Billmate.ACCEPTED == result) Console.WriteLine("Accepted");
            else if (Billmate.PENDING == result) Console.WriteLine("Pending");
            else if (Billmate.DENIED == result) Console.WriteLine("Denied");

            Console.ReadLine();
        }
    }
}
