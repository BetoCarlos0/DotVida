using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotVida.Domain.Entities.Interfaces
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
        public int MyProperty { get; set; }
    }
}
