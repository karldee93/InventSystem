using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item Object", menuName = "Item System/Add Item", order = 2)]
public class ItemObject : ScriptableObject
{
    public GameObject itemPrefab; // To be used whem spawning (e.g. dropping) and should be referenced inside the prefabs too
    public Sprite icon;

    public string itemName;
    [TextArea(4, 16)]
    public string description;

    public float weight = 0;
    public int maxStackableQuantity = 1; // For when you may decide to have bundles of items such as arrows

    public bool useOnPickup = true; // if true, item will be used on pickup (otherwise storaged)
    public bool consumable = true; // If true, item will be destoryed (or quantity decremented if greated than 1) when used

}
