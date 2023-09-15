using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.DtoModels.Authenticate
{
    public class UserRegisterDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }= false;


    }
}
