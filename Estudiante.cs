using System;
namespace Examen
{
    class Estudiante
    {

        public string nombre{set;get;}
        public string apellido{set;get;}
        public string nombreinstitucion{set;get;}
        public int cedula{set;get;}

        public Estudiante(string nombre,string apellido,string nombreinstitucion,int cedula)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.nombreinstitucion=nombreinstitucion;
            this.cedula=cedula;
        }
        public void Imprimir()
        {
            Console.WriteLine("Datos del Estudiante");
            Console.WriteLine("Nombre: " +nombre);
            Console.WriteLine("Apellido: " +apellido);
            Console.WriteLine("Nombre de Institución: " +nombreinstitucion);
            Console.WriteLine("Cédula de Identidad: " +cedula);
        }     
        public void registrar()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Estudiante:" +nombre+ " " +apellido);
            Console.WriteLine("Nombre de Institución: "+nombreinstitucion);
            Console.WriteLine("Cédula de identidad: "+cedula);
            
        } 
    }
}