//Sergio Ruescas
using System;
using System.Collections.Generic;

class Book : IComparable<Book>
{
    public string Titulo { set; get; }
    public int CantidadDePaginas { set; get; }
    public string Autor { set; get; }

    public Book(string Titulo,string  Autor, int CantidadDePaginas)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.CantidadDePaginas = CantidadDePaginas;
    }

    public int CompareTo(Book other)
    {
        return this.Titulo.CompareTo(other.Titulo);
    }

    public override string ToString()
    {
        return Titulo + ", " + Autor + ", " + CantidadDePaginas; 
    }
}

class TestBooks
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        int input, cantPag;
        string titulo, autor, buscar;

        do
        {
            Console.WriteLine("1. Añadir un nuevo libro");
            Console.WriteLine("2. Buscar por texto");
            Console.WriteLine("0. Salir");

            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                if (input == 1)
                {
                    Console.Write("Introduce titulo: ");
                    titulo = Console.ReadLine();
                    Console.Write("Introduce autor: ");
                    autor = Console.ReadLine();
                    Console.Write("Introduce cantidad de paginas: ");
                    cantPag = Convert.ToInt32(Console.ReadLine());

                    books.Add(new Book(titulo, autor, cantPag));
                    books.Sort();
                }
                else
                {
                    Console.Write("Introduce texto a buscar: ");
                    buscar = Console.ReadLine().ToUpper();

                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Titulo.ToUpper().Contains(buscar) ||
                                books[i].Autor.ToUpper().Contains(buscar))
                            Console.WriteLine(books[i]);
                    }
                }

            }
        } while (input != 0);
    }
}

