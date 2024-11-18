using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PassengerCar : Car
{
    protected string BodyType { get; set; }

    //protected override int max_speed { get => base.max_speed; set { if (value > 10 && value < 130) base.max_speed = value; } }
    
    //protected override int power { get => base.power; set { if (value > 10 && value < 90) base.power = value; } }

    public PassengerCar(string type_of_drive, string car_Color, string BodyType) : base(type_of_drive, car_Color)
    {
        this.BodyType = BodyType;
        //base.max_speed = 120;
        //base.power = 80;
        PassengerCars++;
    }

    public PassengerCar()
    {
        BodyType = "Sedan";
        PassengerCars++;
        //base.max_speed = 120;
        //base.power = 80;
    }

    /*protected override void Print()
    {
        Debug.Log("Вызываю печать характеристик машины");
        Debug.Log(base.GetCharacteristics() + $"\nBodyType: {BodyType}");
    }

    public void GoPrint()
    {
        this.Print();
    }*/
}
