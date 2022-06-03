using System;
namespace Examen
{
    class estudiantep:Estudiante
    {
        public int valorfa{set;get;}

        public estudiantep(string nombre,string apellido,string nombreinstitucion,int cedula):base(nombre,apellido,nombreinstitucion,cedula)
        {
            valorfa=100;
        }
        public void Calcular()
        {
            int total,años;
            //Console.WriteLine("Ingrese el valor fijo anual");
            //valorfa=int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el número de años");
            //años=int.Parse(Console.ReadLine());
            //total=años*valorfa;

            Console.WriteLine("El valir de la matrícula inicial es: "+valorfa);
        }
    }
}