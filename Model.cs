using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model<T> : MonoBehaviour
{
    public T model { get; set; }
    public T countOwners { get; set; }
    public Model(T model, T countOwners)
    {
        Debug.Log("Вызывается конструктор класса Model");
        this.model = model;
        this.countOwners = countOwners;
    }
}
