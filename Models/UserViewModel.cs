using System.ComponentModel.DataAnnotations;

namespace ProjetoN2.Models
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Display(Name ="Confirma Password")]
        public string ConfirmPassword { get; set; }
        public string Error { get; set; }
    }
}