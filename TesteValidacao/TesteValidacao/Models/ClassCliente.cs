using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TesteValidacao.Models
{
    public class ClassCliente
    {
        [Required(ErrorMessage = "O campo Código é obrigatório",AllowEmptyStrings=false)]
        [Display(Name="Código: ")]
        public int  cli_id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [Display(Name = "Nome: ")]
        [StringLength(30,MinimumLength=5)]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo Idade é obrigatório")]
        [Display(Name = "Idade: ")]
        [Range(10,20,ErrorMessage="A idade deve estar entre 10 e 20.")]
        public int idade { get; set; }

        [Required(ErrorMessage="O campo Email é obrigatório")]
        [Display(Name = "Email: ")]
        [RegularExpression(".+\\@.+\\+",ErrorMessage="Email inválido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        [Display(Name = "Preço: ")]
        public double preco { get; set; }

    }
}