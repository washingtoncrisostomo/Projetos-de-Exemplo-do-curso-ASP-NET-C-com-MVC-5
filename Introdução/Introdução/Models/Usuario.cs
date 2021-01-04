using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Introdução.Models
{
    public class Usuario
    {
        [Required(ErrorMessage="O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5,ErrorMessage = "Insira uma observação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage ="A idade permitida é 18 a 70 anos")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage="Esse Login Já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmarSenha { get; set; }
    }
}