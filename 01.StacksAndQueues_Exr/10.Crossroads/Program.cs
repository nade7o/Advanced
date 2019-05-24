using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueOfCars = new Queue<string>();

            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            bool isHitted = false;
            string hittedCarName = string.Empty;
            char hittedSymbol = '\0';
            int totalCars = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentGreenLight = greenLightDuration;

                while (currentGreenLight > 0 && queueOfCars.Count > 0)
                {
                    string carName = queueOfCars.Dequeue();
                    int carLength = carName.Length;

                    if (currentGreenLight - carLength >= 0) //green light successfully passed
                    {
                        currentGreenLight -= carLength;
                        totalCars++;
                    }
                    else
                    {
                        // free window succefully passed
                        currentGreenLight += freeWindowDuration;

                        if (currentGreenLight - carLength >= 0)
                        {
                            totalCars++;
                            break;
                        }
                        else
                        {
                            //car hitted
                            isHitted = true;
                            hittedCarName = carName;
                            hittedSymbol = carName[currentGreenLight];
                            break;
                        }
                    }
                }
                if (isHitted)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hittedCarName} was hit at {hittedSymbol}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
