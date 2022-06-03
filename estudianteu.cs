using System;
namespace Examen
{
    class estudianteu:Estudiante
    {
        public int cantidadcreditos{set;get;}
        public int preciocredito{set;get;}

        public estudianteu(string nombre,string apellido,string nombreinstitucion,int cedula):base(nombre,apellido,nombreinstitucion,cedula)
        {
            this.cantidadcreditos=cantidadcreditos;
            preciocredito=7;
        }

        public void Calcular()
        {
            int totalu;
            Console.WriteLine("Ingrese la cantidad de creditos");
            cantidadcreditos=int.Parse(Console.ReadLine());
            totalu=cantidadcreditos*preciocredito;

            Console.WriteLine("El valor de la matrícula anual es: " +totalu);
        }
    }
}