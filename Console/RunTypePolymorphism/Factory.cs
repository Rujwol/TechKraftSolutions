using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTypePolymorphism
{
    internal class Factory
    {
        private List<Person> people = new List<Person>();
        public Factory()
        {
            people.Add(new Customer());
            people.Add(new Lead());
        }
        public IPerson CreateObj(int index)
        {
            return people[index];
        }

    }
}
