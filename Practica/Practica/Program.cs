// See https://aka.ms/new-console-template for more information



//PASO 1: LECTURA DE DATOS
using System.ComponentModel.Design;

Console.Write("Ingrese la primera nota ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese la segunda nota ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese la tercera nota ");
int n3 = int.Parse(Console.ReadLine());


//PASO 2: PROCESO
int suma = n1 + n2 + n3;
int promedio = suma / 3;


//PASO 3: RESULTADOS
if (promedio >= 11)
    Console.WriteLine("El estudiante aprobó");
else
    Console.WriteLine("El estudiante no aprobó");