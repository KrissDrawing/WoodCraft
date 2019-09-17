using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MaterialType", menuName = "Shop/Material")]
public class MaterialType : ScriptableObject
{
    public string materialName;
    public Vector3 dimensions;
    public int price;
    
}

