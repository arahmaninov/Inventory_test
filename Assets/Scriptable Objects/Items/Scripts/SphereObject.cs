using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sphere Object", menuName = "Inventory System/Items/Sphere")]
public class SphereObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Sphere;
    }
}
