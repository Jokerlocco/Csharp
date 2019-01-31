// Javier Benajes

using System;

class Encrypter
{
    public string Encrypt(string s)
    {
        string newS = "";

        foreach (char c in s)
        {
            newS += (char)(c + 1);
        }

        return newS;
    }

    public string Decrypt(string s)
    {
        string newS = "";

        foreach (char c in s)
        {
            newS += (char)(c - 1);
        }

        return newS;
    }
}

class EncrypterTest
{
    public static void Main()
    {
        Encrypter e = new Encrypter();
        string nuevoTexto = e.Encrypt("Hola");
        Console.WriteLine(nuevoTexto);
        nuevoTexto = e.Decrypt(nuevoTexto);
        Console.WriteLine(nuevoTexto);
    }
}
