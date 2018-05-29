using System;

namespace DesignPatternsStudy
{
    public class Twich : OffensiveOperator
    {
        public Twich()
        {
            Dronning = 2;
        }

        public int Dronning { get; internal set; }

        string Skill = "Activate Shoke Dron";

        public void ActivateDron()
        {
            Dronning -= 1;
            Console.WriteLine(Skill);
        }

        
    }
    
}