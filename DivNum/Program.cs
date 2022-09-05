using System;

namespace ProblemaDos {
    class Program {
        static void Main(String[] args){
            System.Console.WriteLine("Dividir 2 numeros\n");
            try {
                System.Console.WriteLine("Num uno: ");
                int numUno = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Num dos: ");
                int numDos = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"{numUno} / {numDos} = {numUno / numDos}");
            }catch(DivideByZeroException ex){
                System.Console.WriteLine("Error Divsion por 0");
            }catch(OverflowException ex){
                System.Console.WriteLine("Error, numero demaciado grande");
            }catch(FormatException ex){
                System.Console.WriteLine("Error no ingresaste un numero");
            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}