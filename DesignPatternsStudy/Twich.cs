using System;

namespace DesignPatternsStudy
{
    public class Twich
    {
        public Twich()
        {
            Dronning = 2;
        }

        public int Dronning { get; internal set; }

        public void ActivateDron()
        {
            Dronning -= 1;
            Console.WriteLine("감전드론을 작동합니다");
        }
    }
    
}