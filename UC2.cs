using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Snake_and_Ladder
{
    public class UC2
    {
        public static void solution()
        {
            Random random=new Random(7);
            int diceoutput = random.Next(7);
            int position = 0;
            Console.WriteLine("The diceoutput number:" + diceoutput);
        }
    }
}
