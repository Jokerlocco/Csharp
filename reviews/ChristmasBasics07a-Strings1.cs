/*
Crea una función llamada "CadenaRepetitiva", que reciba como parámetros una 
letra y un número, y devuelva una cadena formada por esa letra, repetida tantas 
veces como indique el número. Crea una función "CambiarLetra", que reciba una 
cadena, una letra y una posición, y devuelva como resultado la misma cadena, 
pero en la que se haya modificado el carácter que hay en esa posición, para 
dejar en su lugar la letra indicada por el usuario. Por ejemplo, 
CambiarLetra("Hola", 'j', 2) devolvería como resultado "Hoja". 

Crea también un programa de prueba, que te permita saber si el funcionamiento 
de esas funciones es correcto.
*/

// Manuel Lago

using System;
using System.Text;

public class Repetitiva
{
    public static string CadenaRepetitiva( char letra, int num )
    {
        string cadena = "";
        for ( int i = 0 ; i < num ; i++ )
        {
            cadena += letra;
        }        
        return cadena;
    }
    
    public static string CambiarLetra (
        string cadena, char letra, int posicion )
    {
        StringBuilder cadenaModificada = new StringBuilder(cadena);        
        cadenaModificada[posicion] = letra;
        return Convert.ToString(cadenaModificada);
    } 
    
    public static void Main()
    {
        Console.WriteLine(CadenaRepetitiva('h',5));
        Console.WriteLine(CambiarLetra("Hola",'j',2));
    }
}
