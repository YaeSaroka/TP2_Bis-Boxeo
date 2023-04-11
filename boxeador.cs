class boxeador
{
    //Atributos
    public string Nombre {get;set;}
    public string Pais {get;set;}
    public int Peso {get;set;}
    public double Potencia_Golpes {get;set;}
    public double Velocidad_Piernas {get;set;}
    private double total_skill{get;set;}

//Constructor
public boxeador (string name, string country, int weight, double punching_power, double legs_speed)
{
    Nombre=name;
    Pais=country;
    Peso=weight;
    Potencia_Golpes=punching_power;
    Velocidad_Piernas=legs_speed;
}
public double ObtenerSkill()
{
    int num_aletorio=Funciones.GenerarRandom(1,10);
    double total_skill= Potencia_Golpes*0.8+Velocidad_Piernas*0.6+num_aletorio;
    return total_skill;
} 
}