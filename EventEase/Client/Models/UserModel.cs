using System.ComponentModel.DataAnnotations;

namespace EventEase.Client.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }
    }
}
