using System;

namespace Macrodistrito
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Macrotdistrito m1 = new Macrotdistrito("macro3", 3);
            Macrotdistrito m2 = new Macrotdistrito("maxParedes");
            Macrotdistrito m3 = new Macrotdistrito("cotahuma");
            Macrotdistrito m4 = new Macrotdistrito("macro1");
            Macrotdistrito m5 = new Macrotdistrito("macro2");
            // SOBRECARGA DE METODOS
            m1.calcular("portada");
            m1.calcular();
            m1.calcular(1234,"centro");
            // SOBRECARGA DE OPERADORES
            String zonaX = "centro";
            Console.WriteLine(m1+zonaX);
            m1--;
            int habitantesNuevos = 24124;
            Console.WriteLine(m1*habitantesNuevos);
        }
    }
}