using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class InwentoryWindow : MonoBehaviour
{
    [SerializeField] Inventor TargetItem;
    [SerializeField] RectTransform itemPanel;
    void Start()
    {
        TargetItem.onItemAdded += OnItemAdded;
        Redraw();
    }
    void OnItemAdded(Item obj) => Redraw();
    void Redraw()
    {
        for (var i = 0; i < TargetItem.newItems.Count; i++)
        {
            var item = TargetItem.newItems[i];
            var icon = new GameObject("sprite");
            icon.AddComponent<Image>().sprite = item.sprite;
            icon.transform.parent = itemPanel.transform;
        }
    }
}
