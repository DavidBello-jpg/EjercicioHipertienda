using System;

namespace Ejercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema");
            
            Empleados b1 = new Empleados();
            Almacen b2 = new Almacen();
            b1.IngresarNombre();
            b1.IngresarCedula();
            b1.RegistroSalario();
            
            b2.GuardarFuncion();
            b2.GuardarHoras();

            Console.Read();
        }
    }
}
