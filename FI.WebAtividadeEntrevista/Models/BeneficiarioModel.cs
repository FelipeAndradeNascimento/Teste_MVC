using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long IdBeneficiario { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string NomeBeneficiario { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        public string CPFBeneficiario { get; set; }
    }
}