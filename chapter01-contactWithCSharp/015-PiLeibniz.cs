// Approximation of Pi, version 3 (Leibniz's Formula)
// Kevin Marín Romero

public class ApproximationPi3
{
    public static void Main()
    {
        System.Console.Write("PI approximation by Leibniz's Formula is: ");
        System.Console.WriteLine(
            (1.0 - (1.0/3.0) + (1.0/5.0) - (1.0/7.0) + (1.0/9.0)) 
            * 4.0);
    }
}
