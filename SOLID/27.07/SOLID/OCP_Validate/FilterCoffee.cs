namespace OCP_Validate
{
    internal class FilterCoffee : Coffee
    {
        public override decimal GetTotalPrice(int amount)
        {
            return amount * 100;
        }
    }
}
