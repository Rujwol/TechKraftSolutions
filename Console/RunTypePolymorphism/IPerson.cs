using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTypePolymorphism
{
    internal interface IPerson
    {
        int CustomerType { get; set; }
        string FullName { get; set; }
        string Address { get; set; }
        int Mobilenumber { get; set; }
        void FillForm();
        void Validate();
    }
}
