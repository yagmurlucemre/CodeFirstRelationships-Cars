using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Entities
{
    public class Engineer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        //many to many tipinde liste
        public List<CarEngineer> CarEngineers { get; set; }
    }
}
