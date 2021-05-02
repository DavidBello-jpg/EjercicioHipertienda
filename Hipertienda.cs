using System;

namespace Ejercicio_POO
{

    class Empleados //Clase principal "Empleados"
    {   
        //Datos y atributos de la clase
        private string nombre; 
        private int cedula;
        private double salario;

        //Funciones de acceso a los datos de la clase.
        public string Nombre 
        {
            get {return nombre;}
            set {nombre = value;}
        }

        public int Cedula
        {
            get {return cedula;}
            set {cedula = value;}
        }

        public double Salario
        {
            get {return salario;}
            set {if (value == 0) {salario = 10;}
            salario = value;}   
        }

        //Métodos 

        public string IngresarNombre()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombre = (string)Console.ReadLine();
            return nombre;
        }

        public int IngresarCedula()
        {
            Console.WriteLine("Ingrese cédula de {0}: ",Nombre);
            cedula = Convert.ToInt32(Console.ReadLine());
            return cedula;
        }

        public double RegistroSalario()
        {
            Console.WriteLine("Ingrese el salario de {0}: ",Nombre);
            salario = Convert.ToDouble(Console.ReadLine());
            return salario;
        }
    }

    //Clase heredada: Almacen
        
    class Almacen : Empleados
        {
            private string funcion;
            private int horas_semanales;

            public string Funcion
            {
                get {return funcion;}
                set {funcion = value;}
            }

            public int Horas_Semanales
            {
                get {return horas_semanales;}
                set {horas_semanales = value;}
            }

            public string GuardarFuncion()
            {
                Console.WriteLine("Ingrese su departamento en almacen: ");
                funcion = (string)Console.ReadLine();
                return funcion;
            }    
        
            public int GuardarHoras()
            {
                Console.WriteLine("Ingrese la cantidad de horas semanales: ");
                horas_semanales = Convert.ToInt32(Console.ReadLine());
                return horas_semanales;
            }

        }    
}