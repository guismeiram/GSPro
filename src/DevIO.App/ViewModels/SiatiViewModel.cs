using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class SiatiViewModel
    {   
        [Key]
        public Guid Id { get; set; }
        [DisplayName("Resolvido?")]
        public Boolean Resolvido { get; set; }

        [DisplayName("Resolução")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Resolucao { get; set; }

        [DisplayName("Numero Processo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String NumeroProcesso { get; set; }

        [DisplayName("Nome do Usuario")]
        public DateTime DataCriacaoProcesso { get; set; }

        [DisplayName("Tipo Processo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String TipoProcesso { get; set; }

        [DisplayName("Nome do Processo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String NomeProcesso { get; set; }

        [DisplayName("Nome do Usuario")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String NomeUser { get; set; }
    }
}
