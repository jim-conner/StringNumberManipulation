using System;

namespace StringNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please do stuff...");
            //string userInput = Console.ReadLine();

            //string[] str = { "1", "2", "3" };
            string str = "1,2,3";
            string[] splitStr = str.Split(",");


            for (int i = 0; i < splitStr.Length; i++)
            {
                int.Parse(splitStr[i]);
            }
           
            //int num = int.Parse(str);
            Console.WriteLine(splitStr);

        }
    }
}
