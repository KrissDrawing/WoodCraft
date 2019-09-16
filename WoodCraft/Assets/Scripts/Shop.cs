using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private Sketch[] sketchItem; // array of items

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject SketchItemPrefab;

    private void Start()
    {
        PopulateShop();
    }

    private void PopulateShop()
    {
        for(int i = 0; i < sketchItem.Length; i++)
        {
            
            Sketch si = sketchItem[i];
            GameObject itemObject = Instantiate(SketchItemPrefab, shopContainer);


            itemObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(si));

            itemObject.GetComponent<Image>().sprite = si.sprite;
            itemObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = si.name;
        }
    }

    private void OnButtonClick(Sketch item)
    {
        Debug.Log(item.name);
    }
}
