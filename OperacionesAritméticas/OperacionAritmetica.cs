using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public struct OperacionAritmetica
    {
        public OperacionAritmetica(decimal Operador1, decimal Operador2, tipoOperacion Operacion)
        {
            this.Operador1 = Operador1;
            this.Operador2 = Operador2;
            this.Operacion = Operacion;
        }
        public decimal Operador1 { get; set; }
        public decimal Operador2 { get; set; }
        public tipoOperacion Operacion { get; set; }
}   }
