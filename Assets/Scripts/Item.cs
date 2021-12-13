using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Name", menuName = "SCROBJ/item")]
public class Item : ScriptableObject
{
    public string names = "items";
    public Sprite sprite;
    public int price = 400;
}

