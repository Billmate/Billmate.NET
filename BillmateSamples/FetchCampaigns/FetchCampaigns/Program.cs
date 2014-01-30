using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;
namespace FetchCampaigns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eid: 1111 Replace with your eid. You can find it in Billmate-Online
            //Secret: 111111111111 Replace with your secret. You can find it in Billmate-Online
            //SSL: false SSl should be enabled or not
            //Debug: true View more detailed information about the server communication
            
            Console.WriteLine("Start");
            Billmate bm = new Billmate(1111, "111111111111", false, true);
            

            AdditionalInfo ai = new AdditionalInfo("0", "209", "138");

            object[] result = (object[])bm.FetchCampaigns(ai);

            foreach (object[] row in result)
            {
                foreach (object cell in row)
                    Console.WriteLine(cell.ToString());
            }

            Console.ReadLine();
        }
    }
}
