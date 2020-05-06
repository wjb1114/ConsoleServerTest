using System;

namespace OSRS_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Server";

            Server.Start(16, 26950);

            Console.ReadKey();
        }
    }
}
