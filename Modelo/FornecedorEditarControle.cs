using SGPPC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGPPC.Modelo
{
    public class FornecedorEditarControle
    {
        public bool tem;

        public String mensagem = "";

        public String AlterarForn(Int32 id, string cnpj, string nome, string pais, string cidade, string estado, string status, string v)
        {
            FornecedorAlterarComands loginDal = new FornecedorAlterarComands();
            this.mensagem = loginDal.AlterarForn(id, cnpj, nome, pais, cidade, estado, status);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
