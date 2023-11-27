using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFInalLinguagens.Domain
{
    internal class Cliente
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DtSaida { get; set; }
        public DateTime DtRetorno { get; set; }

        public Cliente(string name, string cPF, string telefone, DateTime dtSaida, DateTime dtRetorno)
        {
            Name = name;
            CPF = cPF;
            Telefone = telefone;
            DtSaida = dtSaida;
            DtRetorno = dtRetorno;
        }
    }
}
