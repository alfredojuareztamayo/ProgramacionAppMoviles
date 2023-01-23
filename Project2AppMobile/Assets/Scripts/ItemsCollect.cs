using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsCollect : MonoBehaviour
{
    public TMP_Text itemsToColectText;
    public string NumberOfItems;
    public Items items;
    void Start()
    {
       // items = new Items();
        NumberOfItems = items.itemsString;
        itemsToColectText= GetComponent<TMP_Text>();
        itemsToColectText.text = NumberOfItems;
       // itemsToColectText.text = NumberOfItems;
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfItems = items.itemsString;
        Debug.Log(NumberOfItems);
        itemsToColectText.text = NumberOfItems;

    }
    private void FixedUpdate()
    {
       
    }

}
