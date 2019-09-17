using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public GameObject detailsPanel;

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
        detailsPanel.SetActive(true);

        detailsPanel.transform.GetChild(0).GetComponent<Image>().sprite = item.sprite;

        Transform informationPanel = detailsPanel.transform.GetChild(1).GetComponent<Transform>();

        informationPanel.GetChild(0).GetComponent<TextMeshProUGUI>().text = item.name;  //Do sth with that
        informationPanel.GetChild(1).GetComponent<TextMeshProUGUI>().text = item.description;
        informationPanel.GetChild(2).GetComponent<TextMeshProUGUI>().text = item.complexity.ToString();
    }
}
