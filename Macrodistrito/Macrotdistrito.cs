using System;

namespace Macrodistrito
{
    public class Macrotdistrito
    {
        private String nombre;
        private int nroZonas;
        private String[] nomZonas = new String [50];
        private int[] nroHabitantes = new int[50];

        public Macrotdistrito(string nombre, int nroZonas)
        {
            this.nombre = nombre;
            this.nroZonas = nroZonas;
            for (int i = 0; i <= nroZonas-1; i++)
            {
                this.nomZonas[i] = "centro";
                this.nroHabitantes[i] = 1000;
            }
        }
        // a) Instanciar un objeto Macrodistrito con 5 zonas y otro objeto Macrodistrito con k zonas
        
        public Macrotdistrito(string nombre)
        {
            this.nombre = nombre;
            this.nroZonas = 5;
            this.nomZonas[0] = "centro";
            this.nroHabitantes[0] = 1234;
            this.nomZonas[1] = "sur";
            this.nroHabitantes[1] = 5246;
            this.nomZonas[2] = "zzz";
            this.nroHabitantes[2] = 7533;
            this.nomZonas[3] = "fff";
            this.nroHabitantes[3] = 8796;
            this.nomZonas[4] = "portada";
            this.nroHabitantes[4] = 4362;

        }

        public void mostrar()
        {
            Console.WriteLine("---- Macrodistrito ----");
            Console.WriteLine("nombre: "+nombre);
            Console.WriteLine("nroZonas: "+nroZonas);
            for (int i = 0; i <= nroZonas-1; i++)
            {
                Console.WriteLine("zona: "+ nomZonas[i]);
                Console.WriteLine("nroHabitantes: "+ nroHabitantes[i]);
            }            
        }
        // SOBRECARGAR UN METODO PARA:
        // SOBRECARGA a) Mostrar el nombre del objeto Macrodistrito donde se encuentra la zona con nombre X
        public void calcular(String nomX)
        {
            Console.WriteLine("---- SOBRECARGA b) Mostrar el nombre del objeto Macrodistrito donde se encuentra la zona con nombre X ----");
            for (int i = 0; i <= nroZonas-1; i++)
            {
                if(nomZonas[i].Equals(nomX))
                    Console.WriteLine("nombreMacrodistrito: "+nombre);
            }
        }
        // SOBRECARGA b) Calcular el total de habitantes de cada Macrodistrito
        public void calcular()
        {
            Console.WriteLine("---- b) Calcular el total de habitantes de cada Macrodistrito ----");
            int c = 0;
            for (int i = 0; i < nroZonas; i++)
            {
                c = c + nroHabitantes[i];
            }
        
            Console.WriteLine("El nro total de habitantes del macrodistrito "+nombre+" es: "+c);
        }
        // SOBRECARGA c) Agregar k habitantes a la zona X en el Macrodistrito donde se encuentre
        public void calcular(int k, String zonaX)
        {
            Console.WriteLine("---- c) Agregar k habitantes a la zona X en el Macrodistrito donde se encuentre ---- ");
            int nuevoHabitantes = 0;
            for (int i = 0; i < nroZonas; i++)
            { 
                if (nomZonas[i].Equals(zonaX))
                {   
                    nuevoHabitantes = nroHabitantes[i];
                    nuevoHabitantes = nuevoHabitantes + k;
                }
            }
            Console.WriteLine("nuevo nroHabitantes de la zona: "+zonaX+" es: "+ nuevoHabitantes);
        }
        // SOBRECARGAR UN OPERADOR para cada inciso
        public static String operator +(Macrotdistrito a,string nomX)
        {
            Console.WriteLine("---- SOBRECARGA b) Mostrar el nombre del objeto Macrodistrito donde se encuentra la zona con nombre X ----");
            for (int i = 0; i <= a.nroZonas-1; i++)
            {
                if(a.nomZonas[i].Equals(nomX))
                    return ("nombreMacrodistrito: "+a.nombre);
            }
            return "no existe la zona con ese nombre";
        }

        public static Macrotdistrito operator --(Macrotdistrito a)
        {
            Console.WriteLine("---- SOBRECARGA OPERADOR b) Calcular el total de habitantes de cada Macrodistrito ----");
            int c = 0;
            for (int i = 0; i < a.nroZonas; i++)
            {
                c = c + a.nroHabitantes[i];
            }

            Console.WriteLine("El nro total de habitantes del macrodistrito "+a.nombre+" es: "+c);
            return a;
        }
        public static int operator *(Macrotdistrito a, int k)
        {
            Console.WriteLine("---- SOBRECARGA OPERADOR c) Agregar k habitantes a la zona X en el Macrodistrito donde se encuentre ---- ");
            int nuevoHabitantes = 0;
            Console.Write("ingrese la zona: ");
            String zonaX = Console.ReadLine();
            for (int i = 0; i < a.nroZonas; i++)
            { 
                if (a.nomZonas[i].Equals(zonaX))
                {   
                    nuevoHabitantes = a.nroHabitantes[i];
                    nuevoHabitantes = nuevoHabitantes + k;
                }
            }
            Console.Write("nuevo nroHabitantes de la zona: "+zonaX+" es: ");
            return nuevoHabitantes;
        }

        public string Nombre => nombre;

        public int NroZonas => nroZonas;

        public string[] NomZonas => nomZonas;

        public int[] NroHabitantes => nroHabitantes;
    }
}