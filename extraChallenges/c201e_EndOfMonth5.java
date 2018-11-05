// Reto 2.01: Fin de mes
// Versión Java alternativa

/*
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50

Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
*/

import java.util.*;

public class FinDeMes2
{
    public static void main(String[] args)
    {
        Scanner entrada = new Scanner(System.in);
        int casosPrueba = entrada.nextInt();
        
        for(int i = 0; i < casosPrueba; i++)
        {
            short enCuenta = entrada.nextShort();
            short gastos = entrada.nextShort();
            
            System.out.println((enCuenta + gastos >= 0) ? "SI" : "NO");
        }
    }
}
