using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeLadder
{
    internal class UC2_dieCheck
    {
        public void dieCheck()
        {
            int START_POSITION = 0;

            Console.WriteLine("Welcome to snake ladder game");
            Console.WriteLine("Player will start from zero position");

            //Die Check
            Random random = new Random();
            int dieCheck = random.Next(0, 7);
            if (dieCheck == 0)
            {
                dieCheck = dieCheck + 1;

            }
            Console.WriteLine("Number on die is: " + dieCheck);
        }
    }
}
