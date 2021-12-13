using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventor : MonoBehaviour
{
    public Action<Item> onItemAdded;
    public List<Item> startItemsList = new List<Item>();
    public List<Item> newItems = new List<Item>();
    void Awake()
    {
        for (var i = 0;i<startItemsList.Count;i++)
        {
            AddItems(startItemsList[i]);
        }
  
    }

    public void AddItems(Item item)
    {
        newItems.Add(item);
        onItemAdded?.Invoke(item);
    }
}
