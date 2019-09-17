using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaterialManager : MonoBehaviour
{

    [Header("List of materials")]
    [SerializeField] private MaterialType[] materialItem; // array of items

    [Header("References")]
    [SerializeField] private Transform materialContainer;
    [SerializeField] private GameObject materialItemPrefab;

    private void Start()
    {
        PopulateMaterialPicker();
    }

    private void PopulateMaterialPicker()
    {
        for (int i = 0; i < materialItem.Length; i++)
        {

            MaterialType mt = materialItem[i];
            GameObject itemObject = Instantiate(materialItemPrefab, materialContainer);


            itemObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(mt));

            //itemObject.GetComponent<Image>().sprite = mt.sprite;
            itemObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = mt.materialName;
        }
    }

    private void OnButtonClick(MaterialType item)
    {
        Debug.Log(item.materialName);
    }
}
