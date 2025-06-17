/*
Ejercicio 1
Dentro de su repositorio cree una carpeta que se llame “LectorDirectorio” y en ella crear
una aplicación de consola en C# que permita al usuario explorar el contenido de un directorio,
listar sus archivos y generar un informe en formato CSV con información relevante sobre dichos
archivos.
1. Navegación de Directorio:
○ Al iniciar, la aplicación deberá solicitar al usuario que ingrese el path de un
directorio que desea analizar.
○ El programa debe validar si el directorio ingresado existe. Si no existe, deberá
notificar al usuario y solicitarle que ingrese un path válido nuevamente.
○ Una vez que se ha proporcionado un directorio válido, la aplicación deberá listar
en la consola:
*/
using System.IO;
Console.WriteLine("Ingrese la ruta del directorio a analizar: ");
string? path = Console.ReadLine();
while (true)
{
    if (Directory.Exists(path))
    {
        break;
    } 
    else
    {
        Console.WriteLine("El directorio no existe. Ingrese nuevamente: ");
        path = Console.ReadLine();
    }
}
/*■ Todas las carpetas que se encuentran en ese path
Solo el nombre de carpeta*/
Console.WriteLine("Carpetas dentro de la ruta: ");
string[] carpetas = Directory.GetDirectories(path);
foreach (string carpeta in carpetas)
{
    FileInfo info = new FileInfo (carpeta);
    Console.WriteLine($"Nombre: {info.Name}");
}
/*■ Todos los archivos que se encuentran directamente en esa carpeta
Junto a cada nombre de archivo, se deberá mostrar su tamaño en
kilobytes (KB).*/
Console.WriteLine("Archivos dentro de la ruta: ");
string[] archivos = Directory.GetFiles(path);
foreach (string archivo in archivos)
{
    FileInfo info = new FileInfo (archivo);
    Console.WriteLine($"Nombre: {info.Name} - Tamaño: {info.Length} Kb");
}
/*○ Después de listar los archivos, el programa creará un archivo con extensión csv,
llamado "reporte_archivos.csv" en el mismo directorio que se está analizando
(use ruta relativa para el path del mismo).
○ Este archivo CSV deberá contener la siguiente información en columnas
separadas:
■ Nombre del Archivo: El nombre completo del archivo (incluyendo su
extensión).
■ Tamaño (KB): El tamaño del archivo, redondeado a dos decimales.
■ Fecha de Última Modificación: La fecha y hora en que el archivo fue
modificado por última vez.*/