using System;
namespace Arrays
{
    class program
    {
        static void Main(string[] args)
        {
            //int Array[] = {1,2,3,4,5};
            int[] myNumbers =  {25,50,100,1000};
           string[] names = { "mou", "mouni", "mounika" }; 
           myNumbers[0] = 25;
           myNumbers[1] = 50;
           myNumbers[2] = 100;
           myNumbers[3] = 1000;
            int[] evennumber = new int [4];
            evennumber[0] = 25;
            evennumber[1] = 551;
            evennumber[2] = 1001;
            evennumber[3] = 1000;
            Console.WriteLine(myNumbers[3]);
            Console.WriteLine(names[2]);
            foreach(int mynumber in myNumbers)
            {
                Console.WriteLine(mynumber);
            }
            foreach (int even in evennumber)
            {
                Console.WriteLine(even);
            }
        }
    }
}