using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int  firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime= int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

           if (minutes < 10) 
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            
            else
            {
                Console.WriteLine($"{minutes}:{minutes}");
            }



        }
    }
}
