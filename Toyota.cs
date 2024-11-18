using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Toyota : PassengerCar
{
    public string SteeringWheel { get; set; }

    protected override int max_speed { get => base.max_speed; set { if (value > 10 && value < 130) base.max_speed = value; } }

    protected override int power { get => base.power; set { if (value > 10 && value < 90) base.power = value; } }

    public new string Brand { get => $"���������� ����� ������: Toyota{base.Brand}"; set => base.Brand = value; }

    public new string Color { get => $"��������� ���� ������: Light {base.Color}"; set => base.Brand = value; }

    protected override string CanTaxi { get => base.CanTaxi; set => base.CanTaxi = value; }

    protected override string CanLoad { get => base.CanLoad; set => base.CanLoad = value; }

    public Toyota(string type_of_drive, string car_Color, string BodyType, string SteeringWheel) : base(type_of_drive, car_Color, BodyType)
    {
        this.SteeringWheel = SteeringWheel;
        base.max_speed = 120;
        base.power = 80;
    }

    public Toyota()
    {
        SteeringWheel = "right - hand drive";
        base.max_speed = 120;
        base.power = 80;
    }

    public string DoorPrint(int doors)
    {
        Debug.Log("����� ������ DoorPrint");
        Debug.Log($"���������� ������ = {doors}");
        return "";
    }

    public override void Advantages()
    {
        Debug.Log("����� ������, ������� ���������� ������������ � ����������");
        CanTaxi = "������ ����� �������������� � �������� �����";
        CanLoad = "������ �� ����� �������������� ��� ��������� ������";
        Debug.Log($"����: {CanTaxi}, �����: {CanLoad}");
    }

    public override void DowngrateSport()
    {
        Debug.Log("����� ������ ��������� ����� ������");
        Sport = "Standart Edition";
        Debug.Log($"������ ����� ����� ����: {Sport}");
    }

    public new void UpgrateSport()
    {
        Debug.Log("����� ������ ��������� ����� ������");
        Sport = "Ultimate Edition";
        Debug.Log($"������ ����� ����� ����: {Sport}");
    }

    public new void Drive(int mile)
    {
        Debug.Log("������� ����� ������� ����������� ������");
        Debug.Log($"Your mileage: {mileage}");
        base.mileage += mile + 100;
        Debug.Log($"You drive: {mile + 100}; Your mileage: {mileage}");
    }

    protected override void TwistMileage(int mile)
    {
        Debug.Log("������� ����� ������� ���������� ������");
        if (mileage > 200000)
        {
            mileage -= mile;
        }
        else
        {
            mileage -= mile / 10;
        }
        Debug.Log($"New Mileage: {mileage}");
    }

    public void GoTwistMileage(int mile)
    {
        this.TwistMileage(mile);
    }

    protected override void Print()
    {
        Debug.Log("������� ������ ������������� ������");
        Debug.Log(base.GetCharacteristics() + $"\nBodyType: {BodyType}" + $"\nSteeringWheel: {SteeringWheel};");
    }

    public void GoPrint()
    {
        this.Print();
    }
}
