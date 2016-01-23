using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
        }
        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName ("Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

    }
}