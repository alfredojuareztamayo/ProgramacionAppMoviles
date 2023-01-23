using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject item;
    public Items items;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Destroy(gameObject);
    //    items.totalOfItems -= 1;
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        items.totalOfItems -= 1;
    }

}
