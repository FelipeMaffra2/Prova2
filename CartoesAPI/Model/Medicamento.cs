using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartoesAPI.Model
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Descricao { get; set; }
        public string Lote { get; set; }
        public int mesVencimento { get; set; }
        public int anoVencimento { get; set; }
        public string marca { get; set; }
        public string fabricante { get; set; }
    }
}
