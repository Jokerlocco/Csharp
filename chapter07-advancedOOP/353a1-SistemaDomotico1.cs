class AspiradorRobotico : ObjetoConEncendido
{
    protected byte bateria;

    public AspiradorRobotico(bool encendido, string nombre) 
        : base(encendido, nombre)
    {
        bateria = 75;
    }

   
    public byte GetBateria() { return bateria; }


    public override string ToString()
    {
        return base.ToString() + ", Bateria: " + bateria;
    }
}

// -----------------------
﻿
class Calefaccion : CosaQueCalienta
{
    
    public Calefaccion(bool encendido, int temperatura, string nombre) 
        : base(encendido, temperatura, nombre)
    {
        
    }

    public Calefaccion(int temperatura, string nombre) 
        : this(false, temperatura, nombre)
    {

    }

}

// -----------------------
﻿
﻿class CosaQueCalienta : Dispositivo
{
    protected int temperatura;
    protected bool encendido;

    public CosaQueCalienta(bool encendido, int temperatura, string nombre) 
        : base(nombre)
    {
        this.temperatura = temperatura;
        this.encendido = encendido;
    }

    public CosaQueCalienta(int temperatura, string nombre) 
        : this(false, temperatura, nombre)
    {

    }

    public bool GetEncendido() { return encendido; }
    public int GetTemperatura() { return temperatura; }

    public void SetTemperatura(int temperatura) 
    { 
        this.temperatura = temperatura; 
    }

    public void Encender() { encendido = true; }
    public void Apagar() { encendido = false; }



    public override string ToString()
    {
        return base.ToString() + ", Temperatura: " + temperatura 
                   + ", Encendido: " + encendido;
    }
}

// -----------------------
﻿
abstract class Dispositivo
{
    protected string nombre;

    public Dispositivo(string nombre) { this.nombre = nombre; }

    public void SetNombre(string nombre) { this.nombre = nombre; }

    public override string ToString()
    {
        return "Nombre: " + nombre;
    }
}

// -----------------------
﻿
class Horno : CosaQueCalienta
{

    public Horno(bool encendido, int temperatura, string nombre)
        : base(encendido, temperatura, nombre)
    {

    }

    public Horno(int temperatura, string nombre) : this(false, temperatura, nombre)
    {

    }

}

// -----------------------
﻿
class Luz : ObjetoConEncendido
{
    public Luz(bool encendido, string nombre) : base(encendido, nombre)
    {
        
    }


}

// -----------------------
﻿
class ObjetoConEncendido : Dispositivo
{
    protected bool encendido;

    public ObjetoConEncendido(bool encendido, string nombre) : base(nombre)
    {
        this.encendido = encendido;
    }

    public bool GetEncendido() { return encendido; }

    public void Encender() { encendido = true; }
    public void Apagar() { encendido = false; }

    public override string ToString()
    {
        return base.ToString() + ", Estado: " + encendido;
    }
}

// -----------------------
﻿
class ObjetoQueSubeYBaja
{
    protected byte posicion;

    public ObjetoQueSubeYBaja(byte posicion)
    {
        this.posicion = posicion;
    }

    public byte GetPosicion() { return posicion; }
    public void Subir()
    {
        posicion = 100;
    }

    public void Bajar()
    {
        posicion = 0;
    }

    public void Subir(byte porcentaje)
    {
        posicion += porcentaje;
    }

    public void Bajar(byte porcentaje)
    {
        posicion -= porcentaje;
    }
}

// -----------------------
﻿
class Persiana : Dispositivo
{
    protected byte posicion;

    public byte GetPosicion() { return posicion; }

    public Persiana(byte posicion, string nombre) : base(nombre)
    {
        this.posicion = posicion;
    }

    public void Subir()
    {
        posicion = 100;
    }

    public void Bajar()
    {
        posicion = 0;
    }

    public void Subir(byte porcentaje)
    {
        posicion += porcentaje;
    }

    public void Bajar(byte porcentaje)
    {
        posicion -= porcentaje;
    }

    public void Abrir(byte posicion)
    {
        this.posicion = posicion;
    }

    public override string ToString()
    {
        return base.ToString() + ", Posicion: " + posicion;
    }
}

// -----------------------
﻿
class PuertaGaraje : Puerta
{
    protected byte posicion;

    public PuertaGaraje(bool bloqueda, byte posicion, string nombre) 
        : base(bloqueda, nombre)
    {
        this.posicion = posicion;
    }

    //public byte GetPosicion() { return posicion; }

    public void Subir()
    {
        posicion = 100;
    }

    public void Bajar()
    {
        posicion = 0;
    }

    public void Subir(byte porcentaje)
    {
        posicion += porcentaje;
    }

    public void Bajar(byte porcentaje)
    {
        posicion -= porcentaje;
    }

    public override string ToString()
    {
        return base.ToString() + ", Posicion: " + posicion;
    }
}

// -----------------------
﻿
﻿class SistemaDomótico
{
    public static void Main()
    {
        const int OBJETOS = 10;
        int canObjetios = 9;
        Dispositivo[] d = new Dispositivo[OBJETOS];
        d[0] = new Puerta(true, "Puerta de acceso");
        d[1] = new PuertaGaraje(true, 0, "Puerta garaje");
        d[2] = new Toldo(0, "Toldo");
        d[3] = new Luz(true, "Bombilla");
        d[4] = new Calefaccion(false, 20, "Cal1");
        d[5] = new Calefaccion(false, 20, "Cal2");
        d[6] = new Ventana(new Persiana(0, "Persiana 1"), "Ventana 1");
        d[8] = new Ventana(new Persiana(0, "Persiana 2"), "Ventana 2");
        d[7] = new Ventana(new Persiana(0, "Persiana 3"), "Ventana 3");
        string opcion;

        do
        {
            System.Console.WriteLine("1. Bloquear puerta");
            System.Console.WriteLine("2. Desbloquear puerta");
            System.Console.WriteLine("3. Encender luz");
            System.Console.WriteLine("4. Apagar luz");
            System.Console.WriteLine("5. Subir puerta garaje");
            System.Console.WriteLine("6. Bajar puerta garaje");
            System.Console.WriteLine("7. Subir un 25 Persiana 1");
            System.Console.WriteLine("8. Subir un 25 Persiana 2");
            System.Console.WriteLine("9. Subir un 25 Persiana 3");
            System.Console.WriteLine("10. Bajar un 25 Persiana 1");
            System.Console.WriteLine("11. Bajar un 25 Persiana 2");
            System.Console.WriteLine("12. Bajar un 25 Persiana 3");
            System.Console.WriteLine("13. Recoger toldo");
            System.Console.WriteLine("14. Extender toldo");
            System.Console.WriteLine("15. Subir un grado calefaccion");
            System.Console.WriteLine("16. Bajar un grado calefaccion");
            System.Console.WriteLine("17. Ver estado dispositivos");
            System.Console.WriteLine("0. Salir");
            opcion = System.Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    ((Puerta)(d[0])).Bloquear();
                    break;

                case "2":
                    ((Puerta)(d[0])).Desbloquear();
                    break;

                case "3":
                    ((Luz)d[3]).Encender();
                    break;

                case "4":
                    ((Luz)d[3]).Apagar();
                    break;

                case "5":
                    ((PuertaGaraje) (d[1])).Subir();
                    break;

                case "6":
                    ((PuertaGaraje)(d[1])).Bajar();
                    break;

                case "7":
                    ((Persiana)(d[6])).Subir();
                    break;

                case "8":
                    ((Persiana)(d[7])).Subir();
                    break;

                case "9":
                    ((Persiana)(d[8])).Subir();
                    break;

                case "10":
                    ((Persiana)(d[6])).Bajar();
                    break;

                case "11":
                    ((Persiana)(d[7])).Bajar();
                    break;

                case "12":
                    ((Persiana)(d[8])).Bajar();
                    break;

                case "13":
                    ((Toldo)d[3]).Subir();
                    break;

                case "14":
                    ((Toldo)d[3]).Bajar();
                    break;

                case "15":
                    ((Calefaccion)d[4]).
                       SetTemperatura(((Calefaccion)d[4]).
                                      GetTemperatura()+1);
                    ((Calefaccion)d[5]).
                       SetTemperatura(((Calefaccion)d[5]).
                                      GetTemperatura() + 1);

                    break;

                case "16":
                    ((Calefaccion)d[4]).
                       SetTemperatura(((Calefaccion)d[4]).
                                      GetTemperatura() - 1);

                    ((Calefaccion)d[5]).
                       SetTemperatura(((Calefaccion)d[5]).
                                      GetTemperatura() - 1);

                    break;

                case "17":
                    for (int i = 0; i < canObjetios; i++)
                    {
                        System.Console.WriteLine(d[i]);
                    }
                    break;

                case "0":
                    System.Console.WriteLine("Bye!");
                    break;

                default:
                    System.Console.WriteLine("Wrong number!");
                    break;
            }
        } while (opcion != "0");

    }
}

// -----------------------
﻿
class Toldo : Persiana
{
    public Toldo(byte posicion, string nombre) : base(posicion, nombre)
    {
        
    }


}﻿class Ventana : Dispositivo
{
    protected Persiana p;

    public Ventana(Persiana p, string nombre) : base(nombre)
    {
        this.p = p;
    }

    public Persiana GetPersiana() { return p; }

    public override string ToString()
    {
        return base.ToString() + ", Persiana en: " + p.GetPosicion();
    }
}

// -----------------------
﻿
class Puerta : Dispositivo
{
    protected bool bloqueada;

    public Puerta(bool bloqueada, string nombre) : base(nombre)
    {
        this.bloqueada = bloqueada;
    }

    public void Desbloquear()
    {
        bloqueada = false;
    }

    public void Bloquear()
    {
        bloqueada = true;
    }
    
    public bool GetBloqueada()
    {
        return bloqueada;
    }

    public override string ToString()
    {
        return base.ToString() + ", Bloqueo: " + bloqueada;
    }
}
