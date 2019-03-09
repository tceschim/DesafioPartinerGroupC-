using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace primeiroProjeto
{
    class ControleParimonio
    {

        public string Nome { get; private set; }
        public string MarcaId { get; private set; }
        public string Descricao { get; set; }
        public int NTombo { get; private set; }

        public ControleParimonio(string nome, string marcaId, string descricao, int nTombo)
        {
            Nome = nome;
            MarcaId = marcaId;
            Descricao = descricao;
            NTombo = nTombo;
        }

        public override string ToString()
        {
            return "Nome do produto: "
                + Nome
                + ", Id Marca: "
                + MarcaId
                + ", Descrição: $ "
                + Descricao
                + ", Numero do Tombo "
                + NTombo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
