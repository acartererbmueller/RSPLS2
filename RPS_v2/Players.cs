using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_v2
{
    public abstract class Players
    {

        //Member Variables (HAS A)
        public int score;

        //Player needs a list of gestures as member variable
        List<string> handGesture = new List<string>() { "rock", "paper", "scissor", "lizzard", "spock" };






        //Constructor



        //Member Methods (CAN DO)

        public abstract void MakeGesture();

     
        
        
        


















    }
}
