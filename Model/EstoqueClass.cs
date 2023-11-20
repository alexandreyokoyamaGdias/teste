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

        public string Nome_Produto { get; set; }

        public string Descricao { get; set; }

        public string Preco_Unitario { get; set; }

        public string Quantidade { get; set; }

        public string Id_Fornecedor { get; set; }

        public DateTime Data_Hora_Entrada { get; set; }
    }
}
