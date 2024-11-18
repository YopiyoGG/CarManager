using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TruckCar : Car
{
    protected int Load { get; set; }

    //protected override int max_speed { get => base.max_speed; set { if (value > 10 && value < 130) base.max_speed = value; } }

    //protected override int power { get => base.power; set { if (value > 10 && value < 90) base.power = value; } }
    
    public TruckCar(string type_of_drive, string car_Color, int load) : base(type_of_drive, car_Color)
    {
        this.Load = load;
        base.max_speed = 120;
        base.power = 80;
    }

    public TruckCar()
    {
        Load = 1000;
        base.max_speed = 120;
        base.power = 80;
    }

    /*protected override void Print()
    {
        Debug.Log("Вызываю печать характеристик машины");
        Debug.Log(base.GetCharacteristics() + $"\nLoad: {Load}");
    }

    public void GoPrint()
    {
        this.Print();
    }*/
}
