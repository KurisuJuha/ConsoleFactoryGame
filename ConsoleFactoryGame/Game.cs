using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KYapp.ConsoleFactoryGame
{
    public static class Game
    {
        public static GameData gameData = new GameData();
        
        
        public static void Main(string[] args)
        {
            Commands.Commands.Init();
            Items.Items.Init();
            
            BackGround(100, Start, Update);
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                
                Console.Write(">>");
                string command = Console.ReadLine();
                
                Console.ResetColor();
                Parser.Parse(command);
            }
        }
        
        private static async Task BackGround(int span,Action start, Action update)
        {
            start();
            
            while (true)
            {
                await Task.Delay(span);
                update();
            }
        }

        private static void Start()
        {
            
        }

        private static void Update()
        {
            
        }
    }

    public class GameData
    {
        public string name;

        public List<int> structures;
        public List<int> inventory;
    }
}