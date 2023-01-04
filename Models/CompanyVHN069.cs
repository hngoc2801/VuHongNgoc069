using System.ComponentModel.DataAnnotations;
namespace VuHongNgocBTH2.Models
{
    public class CompanyVHN069
    {
        [Key]
        public string CompanyId {get; set;}
        
        public string CompanyName {get; set;}
    }
}