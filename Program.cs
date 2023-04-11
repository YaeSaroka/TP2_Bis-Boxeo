// See https://aka.ms/new-console-template for more information
int opcion=0;
double puntaje_skill1=0,puntaje_skill2=0;
while(opcion!=4)
{
    opcion=Funciones.Menu(opcion);
    Console.Clear();
switch(opcion)
{
    case 1:
    boxeador Box1 =  Agregar_Boxeador(ref puntaje_skill1);
    Console.Clear();
    break;
    case 2:
    boxeador Box2= Agregar_Boxeador(ref puntaje_skill2);
    Console.Clear();
    break;
    case 3:
    break;
}
}


boxeador Agregar_Boxeador(ref double puntajes_skills)
{
    string name= Funciones.IngresarTexto("Ingrese el nombre del boxeador: ");
    string country= Funciones.IngresarTexto("Ingrese el país de origen: ");
    int weight= Funciones.IngresarEntero("Ingrese el peso del boxeador: ");
    double punching_power= Funciones.IngresarDouble("Ingrese la potencia de golpes: ");
    Validar_Entre1y100(punching_power);
    double legs_speed= Funciones.IngresarDouble("Ingrese la velocidad de las piernas: ");
    Validar_Entre1y100(legs_speed);
    return new boxeador(name, country,weight,punching_power,legs_speed);
    Console.WriteLine("Se ha creado el boxeador ",name);
    puntajes_skills=ObtenerSkill(punching_power,legs_speed);
}

static double ObtenerSkill(double punching_power, double legs_speed)
{
    int num_aletorio=GenerarRandom(1,10);
    double total_skill= (punching_power*0.8)+(legs_speed*0.6)+num_aletorio;
    return total_skill;
} 
static int GenerarRandom(int desde, int hasta)
{
    int num;
    Random r = new Random();
    num = r.Next(desde, hasta + 1);
    return num;
}
void Validar_Entre1y100(double atributo)
{
    while(atributo<1 || atributo>100)
    {
        atributo=Funciones.IngresarDouble("-ERROR- La potencia de los golpes debe ser entre 1 y 100. Por favor, Ingrese nuevamente");
    }
}
void Pelear(double puntaje_skill1, double puntaje_skill2)
{
    double diferencia = puntaje_skill1-puntaje_skill2;
    diferencia = System.Math.Abs(diferencia);
    if(puntaje_skill1>puntaje_skill2)
    {
        if(diferencia >= 30)
        {

        }
    }
}