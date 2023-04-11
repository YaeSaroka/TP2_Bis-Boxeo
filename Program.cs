// See https://aka.ms/new-console-template for more information
int opcion=0;
double puntaje_skill1=0,puntaje_skill2=0;
string name1="", name2="";
while(opcion!=4)
{
    opcion=Funciones.Menu(opcion);
    Console.Clear();
switch(opcion)
{
    case 1:
    boxeador Box1 =  Agregar_Boxeador(ref name1);
    puntaje_skill1=Box1.ObtenerSkill();
    Console.Clear();
    break;
    case 2:
    boxeador Box2= Agregar_Boxeador(ref name2);
    puntaje_skill2=Box2.ObtenerSkill();
    Console.Clear();
    break;
    case 3:
    Pelear(puntaje_skill1, puntaje_skill2, name1,name2);
    break;   
}
}

boxeador Agregar_Boxeador(ref string name)
{
    name= Funciones.IngresarTexto("Ingrese el nombre del boxeador: ");
    string country= Funciones.IngresarTexto("Ingrese el país de origen: ");
    int weight= Funciones.IngresarEntero("Ingrese el peso del boxeador: ");
    double punching_power= Funciones.IngresarDouble("Ingrese la potencia de golpes: ");
    Validar_Entre1y100(punching_power);
    double legs_speed= Funciones.IngresarDouble("Ingrese la velocidad de las piernas: ");
    Validar_Entre1y100(legs_speed);
    return new boxeador(name, country,weight,punching_power,legs_speed);
    Console.WriteLine("Se ha creado el boxeador ",name);
}
void Validar_Entre1y100(double atributo)
{
    while(atributo<1 || atributo>100)
    {
        atributo=Funciones.IngresarDouble("-ERROR- La potencia de los golpes debe ser entre 1 y 100. Por favor, Ingrese nuevamente");
    }
}
void Pelear(double puntaje_skill1, double puntaje_skill2, string name1, string name2)
{
    double diferencia = puntaje_skill1-puntaje_skill2;
    diferencia = System.Math.Abs(diferencia);
    Console.WriteLine(puntaje_skill1);
    if(puntaje_skill1==0 || puntaje_skill2==0)
    {
        Console.WriteLine("Debe ingresar valores para pelear");
    }
    else if(puntaje_skill1>puntaje_skill2)
    {
        if(diferencia >= 30 )Console.WriteLine($"Ganó {name1} por KO");
        else if(diferencia>=10 && diferencia<30)Console.WriteLine($"Ganó {name1} por puntos en fallo unánime");
        else Console.WriteLine($"Ganó {name1} por puntos en fallo dividido");
    }
    else
    {
        if(diferencia >= 30 )Console.WriteLine($"Ganó {name2} por KO");
        else if(diferencia>=10 && diferencia<30)Console.WriteLine($"Ganó {name2} por puntos en fallo unánime");
        else Console.WriteLine($"Ganó {name2} por puntos en fallo dividido");
    }
}