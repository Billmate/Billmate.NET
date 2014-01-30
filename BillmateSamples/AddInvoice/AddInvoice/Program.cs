using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;

namespace AddInvoice
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
        	
            Console.WriteLine("Start");
            Billmate bm = new Billmate(1111, "111111111111", false, true);
            
            Address adress = new Address("test@dotnet.com", "0760123456", "0760123456", "Test.net", "test api", "streetname no", "zipcode", "city", 209);
            AdditionalInfo ai = new AdditionalInfo("");

            Article[] articles = new Article[3];
            articles[0] = new Article(1, "VGN-TXN27N/B", "Sony VAIO VGN-TXN27N/B 11.1 Notebook PC", 337499, 25, 0, 32);
            articles[1] = new Article(1, "flatrate_flatrate", "Frakt - Fixed", 6250, 25, 0, 40);
            articles[2] = new Article(1, "invoice_fee", "Faktureringsavgift", 3625, 25, 0, 48);
            object[] result = (object[])bm.AddInvoice("556000-0753", adress, adress, articles, ai);

            foreach (object row in result)
            {
                Console.WriteLine(row.ToString());
            }

            Console.ReadLine();
        }
    }
}
