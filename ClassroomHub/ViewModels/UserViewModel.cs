﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome de usuário obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Senha obrigatória")]
        [PasswordPropertyText(true)]
        public string Password { get; set; }
        [Display(Name = "Nascimento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nascimento obrigatório")]
        public string Birthday { get; set; }
    }
}