class boxeador
{
    //Atributos
    public string Nombre {get;set;}
    public string Pais {get;set;}
    public int Peso {get;set;}
    public double Potencia_Golpes {get;set;}
    public double Velocidad_Piernas {get;set;}

//Constructor
public boxeador (string name, string country, int weight, double punching_power, double legs_speed)
{
    Nombre=name;
    Pais=country;
    Peso=weight;
    Potencia_Golpes=punching_power;
    Velocidad_Piernas=legs_speed;
}

}