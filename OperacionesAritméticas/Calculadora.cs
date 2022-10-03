using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public class Calculadora
    {
        public static decimal Sumar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Restar(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Multiplicacion(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal Division(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public static decimal Modulo(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
       
        public static decimal Operacions(OperacionAritmetica operacionAritmetica)
        {
            decimal result = 0;

            if (operacionAritmetica.Operacion == tipoOperacion.sumar)
            {
                result = Sumar(operacionAritmetica.Operador1, operacionAritmetica.Operador2);
            }
            else if (operacionAritmetica.Operacion == tipoOperacion.restar)
            {
                result = Restar(operacionAritmetica.Operador1, operacionAritmetica.Operador2);
            }
            else if (operacionAritmetica.Operacion == tipoOperacion.multiplicar)
            {
                result = Multiplicacion(operacionAritmetica.Operador1, operacionAritmetica.Operador2);
            }
            else if (operacionAritmetica.Operacion == tipoOperacion.dividir)
            {
                result = Division(operacionAritmetica.Operador1, operacionAritmetica.Operador2);
            }
            else if (operacionAritmetica.Operacion == tipoOperacion.modulo)
            {
                result = Modulo(operacionAritmetica.Operador1, operacionAritmetica.Operador2);
            }

            return result;
        }
        public static Resultado Simultaneas(decimal Operador1, decimal Operador2)
        {
            Resultado Objresult = new Resultado();
            Objresult.suma = Sumar(Operador1, Operador2);
            Objresult.resta = Restar(Operador1, Operador2);
            Objresult.multiplicacion = Multiplicacion(Operador1, Operador2);
            Objresult.division = Division(Operador1, Operador2);
            Objresult.modulo = Modulo(Operador1, Operador2);
            return Objresult;
        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Seleccione la operacion a realizar: ");
            Console.WriteLine("\t1.- Sumar");
            Console.WriteLine("\t2.- Restar");
            Console.WriteLine("\t3.- Multiplicacion");
            Console.WriteLine("\t4.- Dividir");
            Console.WriteLine("\t5.- Modulo");
            Console.WriteLine("\t6.- Todas");
            int Operacion = int.Parse(Console.ReadLine());

            OperacionAritmetica ObjoperacionAritmetica = new OperacionAritmetica();
            ObjoperacionAritmetica.Operador1 = num1;
            ObjoperacionAritmetica.Operador2 = num2;
            ObjoperacionAritmetica.Operacion = (tipoOperacion)Operacion;

            decimal result = Operacions(ObjoperacionAritmetica);

            if (Operacion == 1)
            {
                Console.WriteLine($"El Resultado Es: {result}");
            }
            else if (Operacion == 2)
            {
                Console.WriteLine($"El Resultado Es: {result}");
            }
            else if (Operacion == 3)
            {
                Console.WriteLine($"El Resultado Es: {result}");
            }
            else if (Operacion == 4)
            {
                Console.WriteLine($"El Resultado Es: {result}");
            }
            else if (Operacion == 5)
            {
                Console.WriteLine($"El Resultado Es: {result}");
            }
            else if (Operacion == 6)
            {
                Resultado result2 = Calculadora.Simultaneas(num1, num2);
                Console.WriteLine($"El Resultado De La Suma Es: {result2.suma}");
                Console.WriteLine($"El Resultado De La Resta Es: {result2.resta}");
                Console.WriteLine($"El Resultado De La Multiplicacion Es: {result2.multiplicacion}");
                Console.WriteLine($"El Resultado De La Division Es: {result2.division}");
                Console.WriteLine($"El Resultado Del Modulo Es: {result2.modulo}");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
