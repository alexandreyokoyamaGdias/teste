using SGPPC.Controllerss;
using SGPPC.Data;
using SGPPC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Modelo
{
    public class FornecedorControle
    {
        public bool tem;

        public String mensagem = "";

        public String CadastrarFor(String nome, String cnpj, String pais, String cidade, String estado,String status)
        {
            FornecedorComands loginDal = new FornecedorComands();
            this.mensagem = loginDal.CadastrarFor(nome, cnpj, pais, cidade, estado,status);

            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
