// See https://aka.ms/new-console-template for more information

// enum.GetName();
//String texto = File.ReadAllText(RutaArchivo);
//Console.WriteLine("Contenido :{0}" +texto); Muestra todo
// List<string> LineasDelArchivo = File.ReadAllLines(RutaArchivo).ToList(); Lo transforma en una lista y lo puedo mostrar con foreach.
//String[] MisLineas = {"Prueba1", "Prueba2"};
//File.WriteAllLines(RutaArchivo, MisLineas); Pisa los archivos escritos anteriormente.

//https://json2csharp.com/ → para convertir un archivo json a c#
//http://jsonviewer.stack.hu/ → para visualizar el contenido de un archivo json

using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using precios;

namespace tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Get();

            //  List<EUR> monedas = new List<EUR>();
            //  foreach (var item in monedas)
            //  {
            //      Console.WriteLine(item.description);
            //  }
            
        }

         private static void Get()
         {
             var url = $"https://api.coindesk.com/v1/bpi/currentprice.json";
             var request = (HttpWebRequest)WebRequest.Create(url);
             request.Method = "GET";
             request.ContentType = "application/json";
             request.Accept = "application/json";
         
         
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            preciosMonedas listMonedas = JsonSerializer.Deserialize<preciosMonedas>(responseBody);

                            //Si es una lista utilizo foreach (Provincia prov in ProvinciasArg.Provincias)

                        }
                    }
                } 
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
         
    }
}


