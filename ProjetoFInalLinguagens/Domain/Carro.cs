using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFInalLinguagens.Domain
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public bool Alugado { get; set; }
        public int IdCarro { get; set; }

        public Carro(string modelo, string placa, bool alugado)
        {
            Modelo = modelo;
            Placa = placa;
            Alugado = alugado;
        }
    }
}
