using System;
using System.Threading.Tasks;

namespace KYapp.ConsoleFactoryGame
{
    public static class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("GameStart");

            Start();

            while (true)
            {
                Update();
                Task task = Task.Delay(1000);
                task.Wait();
            }
            
        }

        public static void Start()
        {
            
        }
        
        public static void Update()
        {
            Console.WriteLine("aaaa");
        }
    }
}