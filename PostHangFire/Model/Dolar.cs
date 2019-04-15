using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostHangFire.Model
{
    public static class Dolar
    {

        public static decimal Valor = 2.10M;

        public static void AtualizaCotacao(decimal _valor)
        {
            Valor += _valor;
        }
    }
}
