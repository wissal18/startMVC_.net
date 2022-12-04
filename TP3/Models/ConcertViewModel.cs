using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class ConcertViewModel
    {
        public long ConcertId { get; set; }
        [Display(Name = "Concert Name")]
        public string ConcertName { get; set; }
        [Display(Name = "Concert Description")]
        public string ConcertDescription { get; set; }
        
        [Display(Name = "Date")]
        public string Date { get; set; }
    }
}
