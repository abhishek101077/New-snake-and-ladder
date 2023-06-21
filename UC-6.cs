using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Snake_and_Ladder
{
    public class UC_6
    {
        public static void solution()
        {
            Console.WriteLine("Start the snake and ladder game");
            Console.WriteLine("Single player at starting position 0");
            Console.WriteLine(" ");
            int position = 0;
            int step = 0;
            bool turn = true;
            int MaxPosition = position;




            while (position != MaxPosition)
            {
                if (turn == true)
                {
                    Random random = new Random();
                    int RollDice = random.Next(1, 6);
                    Console.WriteLine("Player rolls the die and get: " + RollDice);
                    Random random1 = new Random();
                    int option = random1.Next(3);

                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Optinc NO PLAY selected " + position);
                                Console.WriteLine("Player stey at same postion");
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("The case of Ladder");
                                Console.WriteLine("Option LADDER selected " + position);
                                Console.WriteLine("Player move ahead " + RollDice);
                                position = RollDice + position;
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("CaseOfSnake");
                                Console.WriteLine("Option SNAKE is selected " + (RollDice + position));
                                Console.WriteLine("Player move behind by " + RollDice);
                                position = position - RollDice;
                                break;
                            }
                    }
                    if (position < 0)
                    {
                        position = 0;
                        Console.WriteLine("Player have to restart from position " + position);
                    }
                    if (position > MaxPosition)
                    {
                        position = position - RollDice;
                        Console.WriteLine(" Your chance is skip. Stay at same position " + position);
                    }
                    step++;
                    Console.WriteLine("Player rolls the dice till now " + step);
                    Console.WriteLine("Current position of the player is: " + position);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}

