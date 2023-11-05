using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Model
{
    public class EstoqueClass
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public string PrecoUnitario { get; set; }

        public string Quantidade { get; set; }

        public string NomeFornecedor { get; set; }

        public DateTime DataHoraEntrada { get; set; }
    }
}
