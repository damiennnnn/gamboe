using System;

namespace gamboe
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GamboeMain())
                game.Run();
        }
    }
}
