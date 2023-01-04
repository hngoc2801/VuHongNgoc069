using System.ComponentModel.DataAnnotations;
namespace VuHongNgocBTH2.Models
{
    public class VHN069
    {
        [Key]
        public string VHNId {get; set;}
        
        public string VHNName {get; set;}
        public string VHNGender {get; set;}
    }
}