using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;

namespace ActivateInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //Eid: 1111 Replace with your eid. You can find it in Billmate-Online
            //Secret: 111111111111 Replace with your secret. You can find it in Billmate-Online
            //SSL: false SSl should be enabled or not
            //Debug: true View more detailed information about the server communication
            //Invoiceid: 111 View more detailed information about the server communication
            
            Billmate bm = new Billmate(1111, "111111111111", false, true);
            AdditionalInfo ai = new AdditionalInfo("");

            string result = (string)bm.ActivateInvoice("111", ai);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
