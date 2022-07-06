﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cube Object", menuName = "Inventory System/Items/Cube")]
public class CubeObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Cube;
    }
}
