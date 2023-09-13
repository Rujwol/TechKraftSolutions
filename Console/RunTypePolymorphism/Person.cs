using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTypePolymorphism
{
    public class Person : IPerson
    {
        public int CustomerType { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Mobilenumber { get; set; }
        public virtual void FillForm()
        {
            Console.WriteLine("Enter the Customer Full Name: ");
            FullName = Console.ReadLine();

            Console.WriteLine("Enter the Customer Address: ");
            Address = Console.ReadLine();

            Console.WriteLine("Enter the Customer Mobile Number: ");
            Mobilenumber = Int64.Parse(Console.ReadLine());
        }

        public virtual void Validate()
        {
        }
    }

    public class Customer : Person
    {
        public int BillAmount { get; set; }
        private DateTime UTCDate;
        public string BillDate { set => UTCDate = DateTime.Parse(value).ToUniversalTime(); }
        public override void FillForm()
        {
            base.FillForm();
            Console.WriteLine("Enter the Customer Bill Amount: ");
            BillAmount = Int32.Parse(Console.ReadLine());
        }
        public override void Validate()
        {
            DateTime tempDate;
            if (string.IsNullOrEmpty(FullName))
            {
                throw new Exception("is not string");
            }
            if (string.IsNullOrEmpty(Address))
            {
                throw new Exception("is not string");
            }
            if (Mobilenumber < 0 || Mobilenumber.ToString().Length > 10)
            {
                throw new Exception("Invalid mob number");
            }
            if (BillAmount < 0)
            {
                throw new Exception("Bill Amount should be greater than zero");
            }
            //date time validate
            //if (!DateTime.TryParse(UTCDate, out tempDate))
            //{
            //    throw new Exception("Invalid mob number");
            //}
            Console.WriteLine("Date submitted successfully!!");
        }
    }
    public class Lead : Person 
    {
        public override void FillForm()
        {
            base.FillForm();
        }
        public override void Validate() 
        {
            if (string.IsNullOrEmpty(FullName))
            {
                throw new Exception("is not string");
            }
            if (string.IsNullOrEmpty(Address))
            {
                throw new Exception("is not string");
            }
            if (Mobilenumber < 0 || Mobilenumber.ToString().Length > 10)
            {
                throw new Exception("Invalid mob number");
            }
            Console.WriteLine("Date submitted successfully!!");
        }
    }
}
