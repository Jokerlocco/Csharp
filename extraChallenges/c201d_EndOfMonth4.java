//Adrián Navarro Gabino
// Reto 2.01: Fin de mes

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

public class FinDeMes
{
    public static void main(String[] args)
    {
        Scanner entrada = new Scanner(System.in);
        
        int casosPrueba = Integer.parseInt(entrada.nextLine());
        
        String[] cuentaCorriente;
        short[] dinero = new short[2];
        
        for(int i = 0; i < casosPrueba; i++)
        {
            cuentaCorriente = entrada.nextLine().split(" ");
    
            dinero[0] = Short.parseShort(cuentaCorriente[0]);
            dinero[1] = Short.parseShort(cuentaCorriente[1]);
            
            System.out.println((dinero[0] + dinero[1] >= 0) ? "SI" : "NO");
        }
    }
}
