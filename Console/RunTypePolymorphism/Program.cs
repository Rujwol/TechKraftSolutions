using RunTypePolymorphism;

namespace RunTypePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson user = null;
            Console.WriteLine("Enter the Customer TYpe; either 0 (Customer) or 1(Lead)");
            int CustomerTypeUI = Int32.Parse(Console.ReadLine());
            Factory factobj = new Factory();
            user = factobj.CreateObj(CustomerTypeUI);
            user.FillForm();
            Console.Read();
        }
    }
}
