namespace DesignPatternsStudy
{
    internal class SledgeAdapter : IDronningAdapter
    {
        private Sledge _offensiveOperator;//이름?

        public SledgeAdapter(Sledge offensiveOperator/*이름?*/)
        {
            _offensiveOperator = offensiveOperator;
        }

        public void Dronning()
        {
            _offensiveOperator.ActivateDron();
        }
    }
}