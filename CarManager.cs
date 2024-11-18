using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    /*Car car1;
    Car car2;
    Car car3;
    BagageManager bagageManager;

    PassengerCar Pcar1;
    PassengerCar Pcar2;
    TruckCar Tcar1;
    TruckCar Tcar2;*/


    Toyota toyota1;
    Toyota toyota2;

    Audi audi1;
    Audi audi2;

    Man man1;
    Man man2;

    Gas gas1;
    Gas gas2;

    public delegate string Doors(int door);
    public delegate string Wheels();

    void Start()
    {
        /*car1 = new Car("rear-wheel drive", "white"); //экземляр 
        car1.CarUpgrade();
        car1.GetCharacteristics();
        Debug.Log(" "););

        car2 = new Car("front-wheel drive", "black"); //экземляр 
        car2.TwistMileage(57400);
        car2.CarUpgrade();
        car2.CarUpgrade();
        Debug.Log(" "););

        car3 = new Car { max_speed = 170, Power = 120 }; //инициализатор 
        Debug.Log(car3.max_speed);
        car3.SetBagage("Box", 19);
        bagageManager = new BagageManager(car3); //экземляр 
        bagageManager.DeleteBagage(car3.bagage);
        Debug.Log(car3.bagage.name);*/

        /*toyota1 = new Toyota();
        toyota1.GoPrint();
        toyota1.UpgrateSport();
        Debug.Log(" ");
        toyota2 = new Toyota("back-wheel drive", "red", "Hatchback", "right");
        toyota2.GoPrint();
        toyota2.GoTwistMileage(15000);
        Debug.Log(" ");

        audi1 = new Audi();
        audi1.GoPrint();
        audi1.Drive(15000);
        Debug.Log(" ");
        audi2 = new Audi("front-wheel drive", "yellow", "Convertible", "left");
        audi2.GoPrint();
        Debug.Log(" ");

        man1 = new Man();
        man1.GoPrint();
        man1.GoCarUpgrade(20);
        Debug.Log(" ");
        man2 = new Man("full-wheel drive", "black", 2000, 1000);
        man2.GoPrint(); 
        Debug.Log(" ");

        gas1 = new Gas();
        gas1.GoPrint();
        Debug.Log(" ");
        gas2 = new Gas("full-wheel drive", "black", 800, 1000);
        gas2.GoPrint();
        gas2.UpdateSpeed();
        Debug.Log(" ");*/

        //toyota1 = new Toyota("back-wheel drive", "red", "Hatchback", "right");
        //toyota1.GoPrint();
        //toyota1.DowngrateSport();
        //Debug.Log(" ");

        //audi1 = new Audi("front-wheel drive", "yellow", "Convertible", "left");
        //audi1.GoPrint();
        //audi1.Advantages();
        //Debug.Log(" ");

        //man1 = new Man("full-wheel drive", "black", 2000, 1000);
        //man1.GoPrint();
        //man1.DowngrateSport();
        //Debug.Log(" ");

        //gas1 = new Gas("full-wheel drive", "black", 800, 1000);
        //gas1.GoPrint();
        //gas1.Advantages();
        //Debug.Log(" ");

        //Car.CountCars();
        //Car.CountPassangerCars();

        //Doors door = new Doors(toyota1.DoorPrint);
        //Debug.Log("Вызывается делегат Doors");
        //door(4);

        //Wheels wheels = new Wheels(gas1.CountWheels);
        //Debug.Log("Вызывается делегат Wheels");
        //wheels();

        Model<int> model1 = new Model<int>(18683, 5);
        Debug.Log("Номер модели: " + model1.model);
        Owners<Model<int>, string> owners1 = new Owners<Model<int>, string>(model1, "2");
        Debug.Log("Количество владельцев: " + owners1.numberOwners.countOwners);

        Model<string> model2 = new Model<string>("23562", "3");
        Debug.Log("Количество владельцев: " + model2.countOwners);
        Owners<Model<string>, int> owners2 = new Owners<Model<string>, int>(model2, 5);
        Debug.Log("Номер модели: " + owners2.numberOwners.model);
    }
}
