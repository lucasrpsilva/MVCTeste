using System.ComponentModel.DataAnnotations;

namespace MVCTeste.Models
{
    public class Empresa
    {
        //Declarando as propriedades iguais a do banco de dados e utilizando o Data Anotations para validar
        [Required(ErrorMessage = "Campo Id necessário")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome Necessário")]
        [MaxLength(255, ErrorMessage = "O campo Nome permite no máximo {0} caractéres")]
        public string Nome { get; set; }

        [MaxLength(255, ErrorMessage = "O campo Site permite no máximo {0} caractéres")]
        public string? Site { get; set; }

        [Display(Name = "Quantidade de Funcionários")]
        [Required(ErrorMessage ="Campo Quantidade de Funcionários necessário")]
        public int QuantidadeFuncionarios { get; set; }
    }
}
