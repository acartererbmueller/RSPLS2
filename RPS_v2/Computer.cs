using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_v2
{
    public class Computer : Players
    {


        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public override void MakeGesture()
        {

            Console.WriteLine("Please choose a hand gesture!");
            Console.ReadLine();
            

            List<string> handGesture = new List<string>();

            


            //Computer has to choose a gesture
            //Use random to choose a gesture
            //There needs to be a list to choose from!
        }
    }
}
