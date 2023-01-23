using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{
    public GameObject Win;
    public GameObject Lose;
    public Items items;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FinalWin(); 
    }
    public void FinalWin()
    {
        if (items.totalOfItems == 0)
        {
            Win.SetActive(true);
        }
    }
    //public void FinalLose()
    //{
    //    if (items.totalOfItems == 0)
    //    {
    //        Lose.SetActive(true);
    //    }
    //}
}
