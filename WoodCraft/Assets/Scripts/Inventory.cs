using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<MaterialType> materials = null;
    public List<Sketch> sketches = null;
    public GameObject items; //made items REMADE THIS prolly;

    public int money;


    public void Start()
    {
        money = 100;
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = money.ToString();
    }


    public void AddMaterial()
    {
        //when buing in vendor, decrease money
    }

    public void CashFlow(int amount) {
        money += amount;
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = money.ToString();
    }




   

}
