using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Entities
{

    //many to many olan ilişkiyi temsil edecek
    public class CarEngineer
    {
        //primary key
        public int Id { get; set; }
        //car için foreign key
        public int CarId { get; set; }
        //navigation prop
        public Car Car { get; set; }


        //engineer için foreign key
        public int EngineerId { get; set; }

        //navigation prop
        public Engineer Engineer { get; set; }

        public int NumberOfDays { get; set; }
    }
}
