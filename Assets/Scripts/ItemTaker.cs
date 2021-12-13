using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaker : MonoBehaviour
{
    [SerializeField] Item itemToAdd;
    [SerializeField] Inventor targetInventor;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            targetInventor.AddItems(itemToAdd);
        }
    }
}
