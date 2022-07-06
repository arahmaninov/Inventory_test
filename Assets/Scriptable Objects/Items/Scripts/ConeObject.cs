using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cone Object", menuName = "Inventory System/Items/Cone")]
public class ConeObject : ItemObject
{
    public int restoreHealthValue;
    private void Awake()
    {
        type = ItemType.Cone;
    }
}
