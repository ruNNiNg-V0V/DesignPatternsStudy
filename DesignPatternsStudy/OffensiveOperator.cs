using System;

namespace DesignPatternsStudy
{
    public class OffensiveOperator
    {
        public OffensiveOperator(int Amour, int Speed)
        {
            Dronning = 2;
        }

        public int Dronning { get; internal set; }

        public void ActivateDron()
        {
            Dronning -= 1;
            Console.WriteLine("드론을 작동합니다");
        }
    }
}