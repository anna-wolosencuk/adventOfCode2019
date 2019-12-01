using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the fuel caluclating program");

            List<int> numList = new List<int>();

            using (StreamReader sr = new StreamReader("fuelData.txt"))
            {
                
                string line;
                
                while((line = sr.ReadLine()) != null)
                {
                    
                    numList.Add(Convert.ToInt32(line));
                }
            }

            Console.WriteLine("Starting Calculations\n-----------------------------------------------");
            int[] numArray = new int[numList.Count];
            for (int i = 0; i < numList.Count; i++)
            {
                numArray[i] = Calc(numList[i]);
            }

            int result = 0;
            for(int i=0; i<numArray.Length; i++)
            {
                result += numArray[i];
                
            }

            Console.WriteLine("The amount of fuel needed is: " + result);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            
        }

        static int Calc(int num)
        {
            
            int firstNum = num / 3;
            int secondNum = firstNum - 2;
            return secondNum;
        }

        static int Divide(int num)
        {
            return num / 3;
        }

        static int Minus(int num)
        {
            return num - 2;
        }

    }
}
