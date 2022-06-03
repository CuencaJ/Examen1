using System;
namespace Examen
{
    class estudiantes:Estudiante
    {
        public int nivelcursado{set;get;}
        public int preciofn{set;get;}

        public estudiantes(string nombre,string apellido,string nombreinstitucion,int cedula):base(nombre,apellido,nombreinstitucion,cedula)
        {
            this.nivelcursado=nivelcursado;
            preciofn=20;
        }

        public void Calcular()
        {
            int totals;
            Console.WriteLine("Ingrese el nivel cursado");
            nivelcursado=int.Parse(Console.ReadLine());
            totals=nivelcursado*preciofn;

            Console.WriteLine("El valor de la matrícula es: "+totals);
        }
    }
}