/*
Se desea crear un esqueleto para un sistema informático para una 
pequeña consulta médica.

Para ello, se creará una clase “Consulta”, que englobará a todas las 
demás. El sistema estará previsto para controlar:

    Médicos, enfermeros y pacientes. Para todos ellos se anotará el 
    nombre y los apellidos (en un único campo, con el formato 
    "Apellidos, Nombre"), además de un código numérico. Tendrán un 
    constructor que permita indicar esos dos parámetros, además de 
    Getters y Setters (o propiedades con formato largo) para cada uno 
    de ellos. En el caso de los médicos, existirá además una 
    "especialidad" (por ejemplo, "Oftalmología", junto con su Get y su 
    Set, y un constructor adicional que permita indicar la especialidad 
    además de los otros 2 datos (en el caso del constructor general, 
    que no indica especialidad, se asumirá que ésta es "Medicina 
    general"). Para todos ellos se deberá crear un método ToString, que 
    muestre código, nombre y apellidos y (en el caso de los médicos) 
    especialidad, separados por comas.
    
    Visitas, que a su vez pueden ser Planificadas o Urgencias. Para 
    cada visita se deberá anotar el paciente que se ha atendido y el 
    médico que se ha encargado (como no siempre se precisará un 
    enfermero, este detalle se dejará para la versión 2.0). También 
    será preciso anotar la fecha y hora (como DateTime.Now), el motivo 
    de la visita y el diagnóstico. Además, para las urgencias se 
    anotará un dato booleano que indique si es necesaria una visita 
    posterior o no. Todos estos datos se deberán poder indicar en el 
    constructor, y existirán Getters y Setters para ellos (o 
    propiedades en formato compacto). El método ToString de una visita 
    devolverá el nombre del cliente, nombre del médico, fecha, motivo y 
    diagnóstico, separados por " - ". En caso de que sea planificada, 
    esta información será precedida por "Planificada - ", y en el caso 
    de una urgencia, estará precedida por "Urgencia - ". El método 
    ToString de una urgencia que tenga programada una visita posterior 
    deberá terminar con " (P)".

El cuerpo del programa estará en el método Ejecutar de la clase 
Consulta. Este cuerpo creará dos médicos y un enfermero prefijados y un 
array de pacientes inicialmente vacío. Mostrará cinco opciones:

    Añadir un paciente (pidiendo sus datos por consola)

    Buscar pacientes, a partir de parte de un fragmento de su nombre o 
    apellidos.
  
    Añadir una visita (pidiendo el tipo de visita, el código del 
    paciente, el código del médico, el motivo de la visita y el 
    diagnóstico -la fecha no se pedirá, sino que se tomará el instante 
    actual-; si es urgencia, se preguntará también si se ha planificado 
    una visita posterior).
  
    Ver todas las visitas.
  
    Salir

Esta misma clase Consulta será la que también contenga Main. 

Como no sabemos manejar ficheros, esta primera versión provisional 
perderá la información cada vez que termine una sesión.

Recuerda evitar código repetitivo tanto como sea posible, reutilizando 
constructores o métodos cuando corresponda.
*/

//Kevin Marín Romero

using System;

abstract class Persona
{
    protected string nombreApellidos;
    protected int codigo;

    public Persona(string nombreApellidos, int codigo)
    {
        NombreApellidos = nombreApellidos;
        Codigo = codigo;
    }

    public string NombreApellidos
    {
        get { return nombreApellidos; }
        set { nombreApellidos = value; }
    }

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public override string ToString()
    {
        string nombre = nombreApellidos.Substring(
                nombreApellidos.IndexOf(", ") + 2);
        string apellidos = nombreApellidos.Substring(
                0, nombreApellidos.IndexOf(", "));
        return codigo + ", " + nombre + ", " + apellidos;
    }
}

//-------------------------------------------------------------------

class Medico : Persona
{
    protected string especialidad;

    public Medico(string nombreApellidos, int codigo)
        : base(nombreApellidos, codigo)
    {
        especialidad = "Medicina General";
    }

    public Medico(string nombreApellidos, int codigo, string especialidad)
        : this(nombreApellidos, codigo)
    {
        this.especialidad = especialidad;
    }

    public void SetEspecialidad(string especialidad)
    {
        this.especialidad = especialidad;
    }
    public string GetEspecialidad() { return especialidad; }

    public override string ToString()
    {
        return base.ToString() + ", " + especialidad;
    }
}

//-------------------------------------------------------------------

class Enfermero : Persona
{
    public Enfermero(string nombreApellidos, int codigo)
        : base(nombreApellidos, codigo)
    {
    }
}

//-------------------------------------------------------------------

class Paciente : Persona
{
    public Paciente(string nombreApellidos, int codigo)
        : base(nombreApellidos, codigo)
    {
    }
}

//-------------------------------------------------------------------

abstract class Visita
{
    public Paciente Pac { get; set; }
    public Medico Med { get; set; }
    public DateTime FechaHora { get; set; }
    public string Motivo { get; set; }
    public string Diagnostico { get; set; }

    public Visita(Paciente pac, Medico med,
        string motivo, string diagnostico)
    {
        Pac = pac;
        Med = med;
        FechaHora = DateTime.Now;
        Motivo = motivo;
        Diagnostico = diagnostico;
    }

    public override string ToString()
    {
        string nombrePaciente = Pac.NombreApellidos.Substring(
            Pac.NombreApellidos.IndexOf(", ") + 2);
        string nombreMedico = Med.NombreApellidos.Substring(
            Med.NombreApellidos.IndexOf(", ") + 2);

        return nombrePaciente + " - " + nombreMedico + " - " + FechaHora 
            + " - " +Motivo + " - " + Diagnostico;
    }
}

//-------------------------------------------------------------------

class Planificada : Visita
{
    public Planificada(Paciente pac, Medico med,
        string motivo, string diagnostico)
        : base(pac, med, motivo, diagnostico)
    {
    }

    public override string ToString()
    {
        return "Planificada - " + base.ToString();
    }
}

//-------------------------------------------------------------------

class Urgencias : Visita
{
    public bool VisitaPosterior { get; set; }

    public Urgencias(Paciente pac, Medico med,
        string motivo, string diagnostico, bool visitaPosterior)
        : base(pac, med, motivo, diagnostico)
    {
        VisitaPosterior = visitaPosterior;
    }

    public override string ToString()
    {
        return "Urgencia - " + base.ToString() 
            + (VisitaPosterior ? "(P)" : "");
    }
}

//-------------------------------------------------------------------

class Consulta
{
    public void Ejecutar()
    {
        Persona[] medicos = new Medico[2];
        medicos[0] = new Medico("Wazowski, Mike", 0001, "Oftalmólog");
        medicos[1] = new Medico("Sullivan, James P.", 0002);

        Persona enfer = new Enfermero("Boggs, Randall", 0003);

        const int SIZE = 10000;
        Persona[] pacientes = new Paciente[SIZE];
        Visita[] visitas = new Visita[SIZE];

        int pacienteAcutal = 0;
        int visitaAcutal = 0;

        char opcion;

        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Añadir Paciente");
            Console.WriteLine("2. Buscar Paciente");
            Console.WriteLine("3. Añadir Visita");
            Console.WriteLine("4. Ver todas las visitas");
            Console.WriteLine("Q. Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (opcion)
            {
                case '1':
                    if (pacienteAcutal > SIZE)
                    {
                        Console.WriteLine("Base de datos llena");
                    }
                    else
                    {
                        Console.Write("Introduce Apellidos y Nombre ({0}): ",
                            pacienteAcutal + 1);
                        string nombre = Console.ReadLine();
                        Console.Write("Introduce el Código ({0}): ",
                            pacienteAcutal + 1);
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        pacientes[pacienteAcutal] = new Paciente(
                            nombre, codigo);

                        pacienteAcutal++;

                        Console.WriteLine("Usuario añadido correctamente!!!");
                    }
                    break;
                case '2':
                    if (pacienteAcutal == 0)
                    {
                        Console.WriteLine("No hay pacientes");
                    }
                    else
                    {
                        Console.Write("Introduce que buscar: ");
                        string texto = Console.ReadLine().ToUpper();
                        bool encontrado = false;

                        for (int i = 0; i < pacienteAcutal; i++)
                        {
                            if (pacientes[i].NombreApellidos.ToUpper().
                                Contains(texto))
                            {
                                encontrado = true;

                                Console.WriteLine(pacientes[i]);
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No hay resultados");
                        }
                    }
                    break;
                case '3':
                    char tipo;
                    do
                    {
                        Console.WriteLine("Tipo de visita: ");
                        Console.WriteLine("1. Planificada");
                        Console.WriteLine("2. Urgencia");
                        Console.Write("Opción: ");
                        tipo = Convert.ToChar(Console.ReadLine());
                    } while (tipo != '1' && tipo != '2');

                    Console.Write("Introduce el código del paciente: ");
                    int codigoPac = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduce el código del médico: ");
                    int codigoMed = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduce el motivo de la visita: ");
                    string visita = Console.ReadLine();

                    Console.Write("Introduce el diagnostivo: ");
                    string diagnostico = Console.ReadLine();

                    bool posterior = false;

                    if (tipo == '2')
                    {
                        Console.Write("¿Se ha planificado una visita" +
                            " posterior? (S/N): ");
                        posterior = Convert.ToChar(
                            Console.ReadLine().ToUpper()) == 'S' ?
                                true : false;

                    }

                    bool listo = false, pacienteOk = false, medicoOk = false;
                    int j = 0;

                    while (!listo && j < pacienteAcutal)
                    {
                        if (pacientes[j].Codigo.CompareTo(codigoPac) == 0)
                        {
                            pacienteOk = true;
                            int k = 0;
                            while (!listo && k < medicos.Length)
                            {
                                if (medicos[k].Codigo.CompareTo(codigoMed)
                                    == 0)
                                {
                                    medicoOk = true;

                                    if (tipo == '1')
                                    {
                                        visitas[visitaAcutal] =
                                            new Planificada(
                                                (Paciente)pacientes[j],
                                                (Medico)medicos[k],
                                                visita, diagnostico);

                                    }
                                    else
                                    {
                                        visitas[visitaAcutal] =
                                            new Urgencias(
                                                (Paciente)pacientes[j],
                                                (Medico)medicos[k],
                                                visita, diagnostico, posterior);
                                    }
                                }
                                k++;
                            }
                        }
                        j++;
                    }

                    if (pacienteOk && medicoOk)
                    {
                        visitaAcutal++;
                        Console.WriteLine("Visita añadida correctamente!!!");
                    }
                    else
                    {
                        Console.WriteLine("Código Erroneo");
                    }
                    break;
                case '4':
                    if (visitaAcutal == 0)
                    {
                        Console.WriteLine("No hay visitas");
                    }
                    else
                    {
                        Console.WriteLine("---------VISITAS---------");

                        for (int i = 0; i < visitaAcutal; i++)
                        {
                            Console.WriteLine(visitas[i]);
                        }
                    }
                    break;
                case 'Q':
                    Console.WriteLine("Hasta luego!!!");
                    break;
                default:
                    Console.WriteLine("Opción desconocida");
                    break;
            }
            Console.WriteLine();
        } while (opcion != 'Q');
    }

    static void Main(string[] args)
    {
        Consulta c = new Consulta();
        c.Ejecutar();
    }
}
