using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;
namespace CreditCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eid: 1111 Replace with your eid. You can find it in Billmate-Online
            //Secret: 111111111111 Replace with your secret. You can find it in Billmate-Online
            //SSL: false SSl should be enabled or not
            //Debug: true View more detailed information about the server communication
            //Personal number: 556000-0753
            //Amount: 10000 = (100 SEK*100)
            
            Console.WriteLine("Start");
            Billmate bm = new Billmate(1111, "111111111111", false, true);
            


            object[] result = (object[])bm.CreditCheck("747", "556000-0753", "10000", "test@test.com", "0760000000");

            foreach (object row in result)
            {
                Console.WriteLine(row.ToString());
            }

            Console.ReadLine();
        }
    }
}
