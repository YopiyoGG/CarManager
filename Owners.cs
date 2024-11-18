using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owners<P, K> : MonoBehaviour
{
    public P numberOwners { get; set; }

    public K numberTrafficAccident { get; set; } 

    public Owners(P numberOwners, K numberTrafficAccident)
    {
        Debug.Log("Вызывается конструктор класса Owners");
        this.numberOwners = numberOwners;
        this.numberTrafficAccident = numberTrafficAccident;
        InfoAccident(ref numberTrafficAccident);
    }

    void InfoAccident<K>(ref K numberTrafficAccident)
    {
        Debug.Log("Вызов метода InfoAccident");
        Debug.Log("Количество ДТП: " + numberTrafficAccident);
    }
}
