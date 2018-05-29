namespace DesignPatternsStudy
{
    internal class TwichAdapter : IDronningAdapter
    {
        private Twich twich;

        public TwichAdapter(Twich offensiveOperator)
        {
            twich = offensiveOperator;
        }

        public void Dronning()
        {
            twich.ActivateDron();
        }
    }
}