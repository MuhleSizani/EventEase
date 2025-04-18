using System.ComponentModel.DataAnnotations;

namespace EventEase.Client.Models
{
    public class RegistrationModel
    {

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Event selection is required.")]
        public int EventId { get; set; }

    }
}
