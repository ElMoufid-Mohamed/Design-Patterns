namespace Template_Method_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            System.Console.WriteLine("Add milk and sugar");
        }

        public override void Brew()
        {
            System.Console.WriteLine("Dripping coffee through filter");
        }
    }
}