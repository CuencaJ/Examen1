using System;
namespace Examen
{
    class Program
    {
    public static void Main(string []args)
    {
        estudiantep estudiante1= new estudiantep("MARIO","PAZ","ULEAM",123456789);
        estudiante1.Imprimir();
        estudiante1.Calcular();

        estudiantes estudiante2=new estudiantes("LUIS","VELEZ","PAQUISHA",987654321);
        estudiante2.Imprimir();
        estudiante2.Calcular();
 
        estudianteu estudiante3=new estudianteu("JUAN","CASTRO","TARQUI",567891234);
        estudiante3.Imprimir();
        estudiante3.Calcular();

        Estudiante obj1=new Estudiante("MARIO","PAZ","ULEAM",123456789);
        Estudiante obj2=new Estudiante("LUIS","VELEZ","PAQUISHA",987654321);
        Estudiante obj3=new Estudiante("JUAN","CASTRO","TARQUI",567891234);

        List<Estudiante> listaestudians=new List<Estudiante>();
        listaestudians.Add(obj1);
        listaestudians.Add(obj2);
        listaestudians.Add(obj3);
        
        foreach(Estudiante item in listaestudians)
        {
            item.registrar();
        }
    }
    }
}
