using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int totalOfItems;
    public GameObject item;
    public string itemsString;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            totalOfItems += 1;
        }
       // Debug.Log(totalOfItems);
        itemsString = totalOfItems.ToString();
       // Debug.Log(itemsString);
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(totalOfItems);
        itemsString = totalOfItems.ToString();
    }
 

    public string itemsToString(int totalItems)
    {
        string ItemString = totalItems.ToString();
        return ItemString;
    }
}
