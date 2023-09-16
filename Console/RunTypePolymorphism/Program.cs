using RunTypePolymorphism;

namespace RunTypePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson user = null;
            Console.WriteLine("Enter the Customer Type; either 0 (Customer) or 1 (Lead)");
            int CustomerTypeUI = Int32.Parse(Console.ReadLine());
            Factory factobj = new Factory();
            user = factobj.CreateObj(CustomerTypeUI);
            user.FillForm();
            user.Validate();
            Console.Read();
        }
    }
}
