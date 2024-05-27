using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Entities
{
    public class LicensePlate
    {
        //Id yazarsak, entity framework bunun primary key ve otomatik artan olduğunu anlar.
        //Buna convention (gelenek) deriz. Eğer geleneklerden farklı bir isim vermek istersek o zaman data annotation veya fluent API ile konfigürasyon yapmamız gereklidir.
        //Data annotation ve fluent API konusuna geleceğiz.
        public int Id { get; set; }
        public string Number { get; set; }

        //Navigation property'si
        public Car Car { get; set; }

        public override string ToString()
        {
            return Id + "-------" + Number;
        }


    }
}
