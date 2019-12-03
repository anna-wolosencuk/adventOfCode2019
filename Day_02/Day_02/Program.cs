using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_02
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            List<int> intList = new List<int>();

            using (StreamReader sr = new StreamReader("intOpCode.txt"))
            {
                string line;
                string[] stringArray = new string[] { "" };
                while ((line = sr.ReadLine()) != null)
                {
                    stringArray = line.Split(',');
                    foreach (string num in stringArray)
                    {
                        intList.Add(Convert.ToInt32(num));

                    }
                }
            }


            // Replace Position 1 with 12
            intList[1] = 12;
            // Replace Position 2 with 2
            intList[2] = 2;

            Console.WriteLine("Formatting\n\n");

            ListTable(intList);
            UpdateTable(intList);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        static void ListTable(List<int> intList)
        {
            
            for (int i = 1; i <= intList.Count; i++)
            {
                Console.Write(intList[i - 1] + ", ");
                if (i % 4 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n");
        }

        static void UpdateTable(List<int> intList)
        {
            
            int rota = 0;
            while(intList[rota] !=99)
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.WriteLine("\n\n--------------------------------------------");
                int value =0;
                if (intList[rota] == 1)
                {
                    value = Add(intList[intList[rota + 1]], intList[intList[rota + 2]]);
                }
                else if (intList[rota] == 2)
                {
                    value = Mult(intList[intList[rota + 1]], intList[intList[rota + 2]]);
                }

                Console.WriteLine("Changing Position " + (rota + 3) + " to " + value);
                intList[intList[rota + 3]] = value;

                ListTable(intList);
                rota += 4;
            }

            Console.WriteLine("Program Halted. Position 0: " + intList[0]);
        }

        

        static int Add(int num1, int num2)
        {
            Console.WriteLine(num1 + " + "+num2 + " = "+(num1+num2));

            return  num1+num2;
        }

        static int Mult(int num1, int num2)
        {
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            return num1 * num2;
            
        }
    } 
}
