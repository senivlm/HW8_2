using System;

namespace HW8_21
{
    class Program
    {
        public delegate bool More_or_Less(int x, int y);
        static void Main(string[] args)
        {
            Utilita utilita = new Utilita();
            More_or_Less more_Or_Less = More;
            utilita.allFunc(more_Or_Less);
        }
        private static bool More(int x, int y)
        {
            if (x <= y)
                return true;
            else return false;
        }
    }
}
