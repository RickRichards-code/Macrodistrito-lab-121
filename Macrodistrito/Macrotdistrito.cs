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
        // b) Mostrar el nombre del objeto Macrodistrito donde se encuentra la zona con nombre X
        public void zonaX(String nomX)
        {
            Console.WriteLine("---- b) Mostrar el nombre del objeto Macrodistrito donde se encuentra la zona con nombre X ----");
            for (int i = 0; i <= nroZonas-1; i++)
            {
                if(nomZonas[i].Equals(nomX))
                    Console.WriteLine("nombreMacrodistrito: "+nombre);
            }
        }
        // c) Calcular el total de habitantes de cada Macrodistrito
        public void totalHabitantes()
        {
            Console.WriteLine("---- c) Calcular el total de habitantes de cada Macrodistrito ----");
            int c = 0;
            for (int i = 0; i < nroZonas; i++)
            {
                c = c + nroHabitantes[i];
            }

            Console.WriteLine("El nro total de habitantes del macrodistrito "+nombre+" es: "+c);
        }
        // d) Agregar k habitantes a la zona X en el Macrodistrito donde se encuentre
        public void agregarHabitantes(int k, String zonaX)
        {
            Console.WriteLine("---- d) Agregar k habitantes a la zona X en el Macrodistrito donde se encuentre ---- ");
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
    }
}