using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : TruckCar
{
    public int MaxWeight { get; set; }

    protected override int max_speed { get => base.max_speed; set { if (value > 10 && value < 130) base.max_speed = value; } }

    protected override int power { get => base.power; set { if (value > 10 && value < 90) base.power = value; } }

    public new string Brand { get => $"���������� ����� ������: Gas{base.Brand}"; set => base.Brand = value; }

    public new string Color { get => $"��������� ���� ������: Dark {base.Color}"; set => base.Brand = value; }

    protected override string CanTaxi { get => base.CanTaxi; set => base.CanTaxi = value; }

    protected override string CanLoad { get => base.CanLoad; set => base.CanLoad = value; }

    public Gas(string type_of_drive, string car_Color, int load, int MaxWeight) : base(type_of_drive, car_Color, load)
    {
        this.MaxWeight = MaxWeight;
        if (this.Load > this.MaxWeight)
        {
            Debug.Log("uploaded a lot");
            this.Load = this.MaxWeight;
        }
        base.max_speed = 120;
        base.power = 80;
    }

    public Gas()
    {
        MaxWeight = 2000;
        if (Load > MaxWeight)
        {
            Load = MaxWeight;
        }
        base.max_speed = 120;
        base.power = 80;
    }

    public string CountWheels()
    {
        Debug.Log("����� ������ CountWheels");
        Debug.Log("���������� ���� = 4");
        return "";
    }

    public override void DowngrateSport()
    {
        Debug.Log("����� ������ ��������� ����� ������");
        Debug.Log("���������� �������� ����� �����, �� �� �� ������������");
    }

    public override void Advantages()
    {
        Debug.Log("����� ������, ������� ���������� ������������ � ����������");
        CanTaxi = "������ �� ����� �������������� � �������� �����";
        CanLoad = "������ ����� �������������� ��� ��������� ������";
        Debug.Log($"����: {CanLoad}, �����: {CanTaxi}");
    }

    public new void UpdateSpeed()
    {
        Debug.Log("������� ����� ������� ��������� ������������ ��������");
        max_speed -= Load / 100;
        Debug.Log($"new max speed: {max_speed}");
    }

    public new void Drive(int mile)
    {
        Debug.Log("������� ����� ������� ����������� ������");
        Debug.Log($"Your mileage: {mileage}");
        base.mileage += mile + 100;
        Debug.Log($"You drive: {mile + 100}; Your mileage: {mileage}");
    }

    protected override void CarUpgrade(int Power)
    {
        Debug.Log("������� ����� ������� �������� ������");
        this.power += Power;
        max_speed += this.power / 10;
        Debug.Log($"new count of horse powers: {this.power}, new max speed: {max_speed}");
    }

    public void GoCarUpgrade(int power)
    {
        CarUpgrade(power);
    }

    protected override void Print()
    {
        Debug.Log("������� ������ ������������� ������");
        Debug.Log(base.GetCharacteristics() + $"\nLoad: {Load}" + $"\nMaxWeight: {MaxWeight};");
    }

    public void GoPrint()
    {
        this.Print();
    }
}