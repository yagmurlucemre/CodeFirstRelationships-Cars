using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Navigation property'si
        public List<Car> Cars { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Surname;
        }
    }
}
