using System;
using empleadoInfo;

namespace datosEmpleados
{
    class Program 
    {   static DateTime PedirFecha ()
        {   
            System.Console.WriteLine("Dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            return new DateTime(anio, mes, dia);
        }
        static Empleado CargarEmpleados()
        {
            var emp = new Empleado();
            System.Console.WriteLine("Apellido: ");
            emp.Apellido = Console.ReadLine();
            System.Console.WriteLine("Nombre: ");
            emp.Nombre = Console.ReadLine();
            System.Console.WriteLine("Fecha de nacimiento");
            emp.FechaNacimiento = PedirFecha();
            System.Console.WriteLine("Fecha de ingreso");
            emp.FechaIngreso = PedirFecha();
            System.Console.WriteLine("Suledo basico: ");
            emp.SueldoBasico = float.Parse(Console.ReadLine());

            return emp;
        }
        static void Main()
        {
            var listEmpleados = new List<Empleado>();
            System.Console.WriteLine("EMPLEADOS");
            System.Console.WriteLine("Ingrese la cantidad\nde empleados que desea\nregistrar: ");
            int cantidadEmp = Convert.ToInt32(Console.ReadLine());

            while (cantidadEmp-- > 0)
            {
                listEmpleados.Add(CargarEmpleados());
            }

            foreach(var emp in listEmpleados)
            {
                emp.MostrarInfo();
            }
            
        }
    }
}