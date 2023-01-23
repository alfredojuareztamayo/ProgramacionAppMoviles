using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AplicationQuitSphere : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Nada que decir, si presionan el GameObject se cierra la app
        {
            CloseApp();
        }
    }
    public void CloseApp()
    {
        Application.Quit();
    }
}
