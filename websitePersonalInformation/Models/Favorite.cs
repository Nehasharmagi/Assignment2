using System;
using System.ComponentModel.DataAnnotations;

namespace websitePersonalInformation.Models
{
    public class Favorite
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName{get;set;}
        public int Age{get;set;}
        
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public string Hobbies{get;set;}
        public string interestingAboutme{get;set;}
    }
}