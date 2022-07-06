using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cylinder Object", menuName = "Inventory System/Items/Cylinder")]
public class CylinderObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Cylinder;
    }
}
