public static class Funciones
{
public static int IngresarEntero(string msj)
{
    Console.WriteLine(msj);
    return int.Parse(Console.ReadLine());
}
public static double IngresarDouble(string msj)
{
    Console.WriteLine(msj);
    return double.Parse(Console.ReadLine());
}
public static string IngresarTexto(string msj)
{
    Console.WriteLine(msj);
    return Console.ReadLine();
}
public static int Menu(int opcion)
{
    do
    {
        Console.WriteLine("1) Cargar Datos Boxeador 1");
        Console.WriteLine("2) Cargar Datos Boxeador 2");
        Console.WriteLine("3) Fight");
        Console.WriteLine("4) Salir");
        opcion= Funciones.IngresarEntero("Ingrese la opción que desea ejecutar: ");
    } while(opcion<0 || opcion>5);
    return opcion;
} 
}