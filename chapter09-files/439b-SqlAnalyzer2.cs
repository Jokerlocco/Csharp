// Manuel Lago
// SQL Analyzer

using System;
using System.IO;
using System.Collections.Generic;

class analizadorSQL
{
    public static void Main(string[] args)
    {
        string nombre;
        
        if(args.Length == 1)
            nombre = args[0];
        else
            nombre = Console.ReadLine();
            
        if(File.Exists(nombre))
        {
            try
            {
                StreamReader leer = new StreamReader(nombre);
                StreamWriter escribir =
                    new StreamWriter(nombre+".exportado.txt");
                
                string linea = leer.ReadLine();
                
                while(linea != null)
                {
                    if(linea != null)
                    {
                        string nombreTabla = "";
                        List<string> camposEscribir = new List<string>();
                        List<string> valoresEscribir = new List<string>();
                        
                        linea = linea.Replace("insert into ", "");
                        nombreTabla = linea.Substring(0,linea.IndexOf(' '));
                        linea = linea.Substring(linea.IndexOf(' ')).Trim();
                        
                        string campos = linea.Substring(linea.IndexOf('(') + 1 ,linea.IndexOf(')') - 1);
                        string values = linea.Substring(linea.LastIndexOf('(') + 1);
                        values = values.Replace(");","");
                        string[] cortar = values.Split('\'');

                        foreach(string s in cortar)
                        {
                            string aux = s;
                                
                            if(aux.Length > 0)
                            {
                                    
                                if(s.StartsWith(","))
                                {
                                    aux = aux.Substring(1).Trim(); 
                                }

                                if(aux.Length != 0)
                                {
                                    valoresEscribir.Add(aux);
                                }
                            }

                        }
                        
                        cortar = campos.Split(',');
                        
                        foreach(string s in cortar)
                        {
                            camposEscribir.Add(s.Trim());
                        }
                        
                        escribir.WriteLine(nombreTabla);
                        
                        for(int i = 0; i < camposEscribir.Count ; i++)
                        {
                            escribir.WriteLine(camposEscribir[i] + ": " + valoresEscribir[i]);
                        }
                        
                        escribir.WriteLine();
                        linea = leer.ReadLine();
                    }
                }
                
                escribir.Close();
                leer.Close();
            }
            catch(IOException io)
            {
                Console.WriteLine(io);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
