using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        //1-1 için yapılacaklar:
        //Foreign key olacak olan sınıfa karşı taraf sınıfıadı + Id ismiyle foreign key prop. si  ve yine karşı taraf cinsinden navigation prop. eklenir. (navigation prop. çoğul DEĞİL)

        //Karşı sınıf ise SADECE zıt taraf cinsinden navigation prop. eklenir. (ÇOĞUL DEĞİL)

        //Foreign key ataması için (eklerken veya güncellerken)
        //SADECE foreign key olan özelliğe atama yapsak yeterli olur.


        //Foreign key
        //Gelenek: Entity framework foreign key olacağını şöyle anlar:
        //Önce ilişkili olacağı class adı sonra da Id kelimesini yanına ekleriz.
        //Foreign key ekledikten sonra ayrıca ilişkide bulunduğu sınıf TÜRÜNDE bir de navigation property yazılı.


        //Navigation property
        //Sınıflar arası geçişi sağlayan özelliklerdir.


        //foreign key'si
        public int? LicensePlateId { get; set; }


        //Navigation property'si
        public LicensePlate LicensePlate { get; set; }

        //Foreign key PersonId
        public int? PersonId { get; set; }

        //Navigation property'si
        public Person Person { get; set; }


        //many to many tipinde liste
        public List<CarEngineer> CarEngineers { get; set; }

    }
}
