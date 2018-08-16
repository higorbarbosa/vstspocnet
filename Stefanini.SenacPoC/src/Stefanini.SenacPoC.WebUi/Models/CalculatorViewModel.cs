using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stefanini.SenacPoC.WebUi.Models
{
    public class CalculatorViewModel
    {
        [Display(Name = "Valor 1")]
        public double Value1 { get; set; }

        [Display(Name = "Valor 2")]
        public double Value2 { get; set; }

        [Display(Name = "Resultado")]
        public double ResultValue { get; set; }

        [Display(Name = "Operadores")]
        public List<SelectListItem> Operators { get; set; }

        [Display(Name = "Operador")]
        public string Operator { get; set; }


        [Display(Name = "Mensagem")]
        public string Message { get; set; }

        [Display(Name = "Resultado Valido?")]
        public bool IsResultValid { get; set; }

        [Display(Name = "Mensagem de Versao do Build")]
        public string BuildVersionMessage { get; set; }
    }
}
