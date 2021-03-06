﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BillmateAPI;

namespace GetAddress
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
            
            bm.ClientIP = "192.0.0.1";
            Array aa = (Array)bm.GetAddress("556000-0753");
            foreach (string[] address in aa)
            {
                foreach(string row in address){
                    Console.WriteLine(row);
                }
            }
            Console.ReadLine();
        }
    }
}
