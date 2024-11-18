using BagageMaster;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class BagageManager : MonoBehaviour
{

    public BagageManager(Car car)
    {
        Debug.Log($"Bagage: {car.bagage.name}");
    }

    public void DeleteBagage(Bagage bagage)
    {
        string name = bagage.name;
        bagage.LeftTheCar();
        Debug.Log(name + " left the car");
    }
}

namespace BagageMaster
{
    public class Bagage
    {
        public string name;
        float weight;

        public Bagage(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
            Debug.Log($"Bagage name: {name}; Bagage weight: {weight} kg");
        }

        public void LeftTheCar()
        {
            this.name = null;
            this.weight = 0;
        }
    }
}
