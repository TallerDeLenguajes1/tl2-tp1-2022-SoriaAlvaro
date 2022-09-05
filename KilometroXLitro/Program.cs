using System;

namespace ProblemaTres {
    class Program {
        static void Main(String[] args){
            System.Console.WriteLine("Kilometros por litros\n");
            try {
                System.Console.WriteLine("Kilometros: ");
                int k = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Litros: ");
                int l = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"{k} Kilometros recorridos / {l} litros consumidos = {k / l} Kilometros por litro");
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