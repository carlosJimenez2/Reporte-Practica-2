using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            facultades Alumno;
            Alumno = new facultades();
            Alumno.Nombre = "Carlos";
            Alumno.Apellidos = "Jimenez Arellano";
            Alumno.Numerodecuenta = 314104326;
            Alumno.Facultad = "Ingenieria";
            Alumno.Semestre = 5;

            Console.WriteLine(" ");
            Console.WriteLine(Alumno.Nombre +" "+ Alumno.Apellidos + " de numero de cuenta " + Alumno.Numerodecuenta);
            Console.WriteLine("Estudia en la facultad de " + Alumno.Facultad + " y cursa el semestre numero " + Alumno.Semestre);
            Console.ReadKey();


        }
    }
}
