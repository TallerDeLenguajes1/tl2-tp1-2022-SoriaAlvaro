using System;

namespace TrabajoPracticoUno {
    class Program {
        static void Main(String[] args){
            System.Console.WriteLine("Cuadrado de un numero\n");
            try{
                int num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine($"{num} ^ 2 = {num*num}");
            }catch(FormatException ex){
                System.Console.WriteLine("No ingresaste un numero");
            }catch(Exception ex){
                System.Console.WriteLine(ex);
            }
        }
    }
}