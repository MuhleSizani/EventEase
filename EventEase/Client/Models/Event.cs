using System.ComponentModel.DataAnnotations;

namespace EventEase.Client.Models
{
    public class Event
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Event name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Event date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Event location is required.")]
        public string Location { get; set; }


    }
}
