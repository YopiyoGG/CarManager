using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owners<P, K> : MonoBehaviour
{
    public P numberOwners { get; set; }

    public K numberTrafficAccident { get; set; } 

    public Owners(P numberOwners, K numberTrafficAccident)
    {
        Debug.Log("���������� ����������� ������ Owners");
        this.numberOwners = numberOwners;
        this.numberTrafficAccident = numberTrafficAccident;
        InfoAccident(ref numberTrafficAccident);
    }

    void InfoAccident<K>(ref K numberTrafficAccident)
    {
        Debug.Log("����� ������ InfoAccident");
        Debug.Log("���������� ���: " + numberTrafficAccident);
    }
}
