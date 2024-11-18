using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BagageMaster;
using System;

public abstract class Car : MonoBehaviour
{
    private string Type_of_drive;
    protected string Sport = "Standart Edition";
    protected int mileage;
    private int Power;
    private int Max_Speed;
    static int cars = 0;
    static int passengercars = 0;

    public static int Cars { get { return cars; } set { cars = value; } }

    public static int PassengerCars { get { return passengercars; } set { passengercars = value; } }

    protected virtual string CanTaxi { get; set; }

    protected virtual string CanLoad { get; set; }

    protected virtual int max_speed  { get => Max_Speed; set { if (value > 10 && value < 110) Max_Speed = value; } } 

    protected virtual int power { get => Power; set { if (value > 10 && value < 70) Power = value; } } 

    protected string Brand { get; set; }
    protected string Color { get; set; }

    public Car()  
    {
        Brand = "";
        Color = "green";
        max_speed = 100;
        power = 60;
        mileage = 51400;
        Type_of_drive = "rear-wheel drive";
        Cars++;
    }

    public Car(string type_of_drive, string car_Color) 
    {
        Brand = "";
        this.Color = car_Color;
        max_speed = 100;
        power = 60;
        mileage = 124700;
        this.Type_of_drive = type_of_drive;
        Cars++;
    }


    public static void CountCars()
    {
        Debug.Log("Вызов метода CountCars");
        Debug.Log($"Общее количество машин: {Cars}");
    }

    public static void CountPassangerCars()
    {
        Debug.Log("Вызов метода CountPassangerCars");
        Debug.Log($"Количество пасажирских автомобилей: {PassengerCars}");
    }

    protected void UpgrateSport()
    {
        Sport = "Upgrated Edition";
    }

    protected void UpdateSpeed()
    {
        Debug.Log("Вызываю метод который уменьшает максимальную скорость");
        max_speed -= 0;
        Debug.Log($"new max speed: {max_speed}");
    }

    public abstract void DowngrateSport();

    public abstract void Advantages();

    protected virtual void Drive(int mile)
    {
        Debug.Log("Вызываю метод который накручивает пробег");
        Debug.Log($"Your mileage: {mileage}");
        mileage += mile;
        Debug.Log($"You drive: {mile}; Your mileage: {mileage}");
    }

    protected virtual void CarUpgrade(int Power)
    {
        Debug.Log("Вызываю метод который улучшает машину");
        this.power += Power;
        max_speed += this.power / 2;
        Debug.Log($"new count of horse powers: {this.power}, new max speed: {max_speed}");
    }

    protected virtual void TwistMileage(int mile)
    {
        Debug.Log("Вызываю метод который скручивает пробег");
        if (mileage > 100000)
        {
            mileage -= mile;
        }
        else
        {
            mileage -= mile / 2;
        }
        Debug.Log($"Mileage: {mileage}");
    }

    protected virtual void Print()
    {
        Debug.Log("Вызываю печать характеристик машины");
        Debug.Log(GetCharacteristics());
    }

    protected string GetCharacteristics()
    {
        return $"Type of drive: {Type_of_drive};\n" +
            $"Color: {Color};\n" +
            $"Brand: {Brand};\n" +
            $"Sport: {Sport};\n" +
            $"Max Speed: {max_speed};\n" +
            $"Power: {power};\n" +
            $"Mileage: {mileage}";
    }

    public Bagage bagage;
    /*public void SetBagage(string name, float weight)
    {
        bagage = new Bagage(name, weight);
        WithBagage();
    }

    private void WithBagage()
    {
        max_speed -= 10;
        Debug.Log($"MaxSpeed dropped to: {max_speed}");
    }*/

}


