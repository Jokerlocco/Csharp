/*

Se acerca el verano y comienzan los nervios y desesperación por 
mantener una línea adecuada. Para ello muchas personas quieren ponerse 
en forma y se ponen en manos del experto nutricionista Dr Ácula.

El Dr Ácula es un doctor muy solicitado y debe ordenar la lista de 
pacientes en función de quien tiene que atender antes. Este aconsejará 
a los pacientes según mayor urgencia tengan. Para ello los ordenará por 
mayor peso y en caso de empate lo hará según una menor altura.

Entrada

En la primera línea un entero P indicando el número de pacientes.
1 <= C <= 10000
Las siguientes P líneas indicarán de cada paciente el peso w y la altura h.
1 <= h <= 100000
1 <= w <= 100000

Salida

Se nos mostrará los pacientes ordenados de mayor a menor, en base a su 
peso y altura según la urgencia de atención.

Ejemplo de entrada
5
90 150
100 120
100 110
77 170
110 161

Ejemplo de salida
110 161
100 110
100 120
90 150
77 170

*/

// Nacho

using System;

class Bikini
{
    class Person : IComparable
    {
        public int W { get; set; }
        public int H { get; set; }
        
        public Person(string definition)
        {
            string[] details = definition.Split();
            W = Convert.ToInt32(details[0]);
            H = Convert.ToInt32(details[1]);
        }
        
        public int CompareTo(object other) 
        {
            if (W < ((Person) other).W)
                return 1;
            
            if (W == ((Person) other).W  && H > ((Person) other).H)
                return 1;
            
            return -1;
        }
        
        public override string ToString()
        {
            return W + " " + H;
        }
    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());

        Person[] people = new Person[p];

        for (int i = 0; i < p; i++)
            people[i] = new Person( Console.ReadLine() );
        
        Array.Sort(people);

        foreach (Person person in people)
            Console.WriteLine(person);
    }
}

