using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Write your number : ");
        int number = int.Parse(Console.ReadLine ());
        if (number == 1) 
        {
            Console.WriteLine("your number is one");

        }
         else if (number == 2)
         {
            Console.WriteLine("your number is two ");

         }
         else if  (number == 3)
         {
            Console.WriteLine("your number is three");
         } 
        else 
        {
            Console.WriteLine("your number is not here");
        }
         

    }
}