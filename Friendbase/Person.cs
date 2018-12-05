using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Friendbase.Trivia.Gender;
namespace Friendbase
{
    class Person
    {
      
        public string Name { get; set; }
        public ushort Age{ get; set; }
        public GenderType Gender { get; set; }
        public DateTime GotToKnow { get; set; }
        public string Place { get; set; }
        public Person(DateTime PGotToKnow,string PName="John Doe",ushort PAge=18,GenderType PGender=GenderType.Other,string PPlace="school")
        {
            GotToKnow = PGotToKnow;
            Name = PName;
            Age = PAge;
            Gender = PGender;
            Place = PPlace;
       
        }
        public Person(Person P)
        {
            Name = P.Name;
            Age = P.Age;
            Gender = P.Gender;
            GotToKnow = P.GotToKnow;
            Place = P.Place;
        }




    }
}
