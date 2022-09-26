using System;

namespace empleadoInfo 
{
    public class Empleado 
    {
        private string nombre;
        private string apellido;
        private string dirrecion;
        private string nombreUniv = "Ninguna";
        private int dni;
        private int hijos;
        private float sueldoBasico;
        private bool isTituloUniv;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;
        private DateTime fechaDivorcio;
        private EstadoCivil estado_Civil;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dirrecion { get => dirrecion; set => dirrecion = value; }
        public string NombreUniv { get => nombreUniv; set => nombreUniv = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Hijos { get => hijos; set => hijos = value; }
        public float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public bool IsTituloUniv { get => isTituloUniv; set => isTituloUniv = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        private EstadoCivil Estado_Civil { get => estado_Civil; set => estado_Civil = value; }

        private enum EstadoCivil
        {
            Casado,
            Divorciado
        }

        public Empleado()
        {
        }

        private int CalcAntiguedad ()
        {
            return DateTime.Today.AddTicks(-this.fechaIngreso.Ticks).Year -1;
        }
        private int CalcEdadEmpleado ()
        {
            return DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year -1;
        }
        private float CalcDescuento ()
        {
            return this.sueldoBasico * 15 / 100;
        }

        private float CalcAdicional ()
        {
            int antiguedad = CalcAntiguedad();
            if(antiguedad >= 20)
            {
                return  this.sueldoBasico * 25 / 100;
            }
            return  this.sueldoBasico * antiguedad / 100;
        }

        private float CalcSalario ()
        {
            float descuento = CalcDescuento();
            float adicional = CalcAdicional();
            return  this.sueldoBasico + adicional - descuento;
        }

        public void MostrarInfo () {
            float salario = CalcSalario();
            int antiguedad = CalcAntiguedad();
            int edad = CalcEdadEmpleado();

            Console.WriteLine($"Apellido: {this.apellido}");
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Antiguedad: {antiguedad}");
            Console.WriteLine($"Salario: {salario}");
        }
    }
}