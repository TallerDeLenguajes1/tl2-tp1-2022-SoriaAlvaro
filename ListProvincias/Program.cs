using System.Net;
using System.Text;
using System.Text.Json;
using ClassProvincias;
using Funciones;

namespace ApiProvincias {
    class Program {
        static void Main(String[] args){
            string url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";

            var datosApi = JsonSerializer.Deserialize<Root>(Functions.Solicitar(url));

            foreach(var elements in datosApi.provincias){
                System.Console.WriteLine($"Provincia: {elements.nombre}");
                System.Console.WriteLine($"ID: {elements.id}");
            }
        }
    }
}