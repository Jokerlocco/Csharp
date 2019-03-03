/*  
 *  Arbol binario de búsqueda  
 *  Implementado en C#
 *  
 *  Nacho Cabanes
 */
 
using System;
 
public class Nodo
{
    private int dato;
    private Nodo hijoIzq;
    private Nodo hijoDer;

    public Nodo(int valor)
    {
        dato = valor;
    }

    public int GetDato()
    {
        return dato;
    }

    public void Insertar(int valor)
    {
        if (valor == dato)  // No permito duplicados
            return;
              
        if (valor > dato)   // Si es mayor, a la derecha
        {
            if (hijoDer == null)   // Si no hay nada, creo un nodo nuevo
                hijoDer = new Nodo(valor);
            else                   // Y si lo hay, delego en él
                hijoDer.Insertar(valor);
        }

        else // Si es menor, a la izquierda
        {
            if (hijoIzq == null)   // Si no hay nada, creo un nodo nuevo
                hijoIzq = new Nodo(valor);
            else                   // Y si lo hay, delego en él
                hijoIzq.Insertar(valor);
        }
    }

    public void EscribirEnOrden()
    {
        if (hijoIzq != null)
            hijoIzq.EscribirEnOrden();

        Console.Write("{0} ", dato);

        if (hijoDer != null)
            hijoDer.EscribirEnOrden();
    }
}

public class Arbol
{
    Nodo raiz;

    public void Escribir()
    {
        if (raiz != null)
            raiz.EscribirEnOrden();
    }
     
    public void Insertar(int valor)
    {
        if (raiz == null)
            raiz = new Nodo(valor);
        else
            raiz.Insertar(valor);
    }
     
    //  Cuerpo del programa, para probar la(s) clase(s)
    public static void Main()
    {
        Arbol a = new Arbol();
        a.Insertar(5);
        a.Insertar(3);
        a.Insertar(7);
        a.Insertar(2);
        a.Insertar(4);
        a.Insertar(8);
        a.Insertar(9);
        a.Escribir();
    }
}
