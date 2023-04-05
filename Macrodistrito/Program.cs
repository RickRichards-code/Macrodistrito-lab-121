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
            m1.zonaX("portada");
            m1.totalHabitantes();
            m1.agregarHabitantes(1234,"centro");
        }
    }
}