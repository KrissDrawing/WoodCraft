using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sketch", menuName = "Shop/Sketch")]
public class Sketch : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite sprite;

    public int qualityPoints;
    public int unlockCost;
    public int complexity;

    public Vector3 minimumDimensions;
    public string material;

}
