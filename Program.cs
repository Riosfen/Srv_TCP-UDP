using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Servidor_TCP
{
    class Program
    {

        static void Main(string[] args)
        {
        
            String WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            Console.WriteLine("¡Arrancando servidor TCP!");

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(WorkingDirectory + "/Server.config");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //split linea y trim (guardar en un array clave valor)
                    if (line.Contains('='))
                    {
                        ///TODO enviar a una clase que se encargue de setear las variables
                        List<string> parts = line.Split('=').Select(p => p.Trim()).ToList();
                    }
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
