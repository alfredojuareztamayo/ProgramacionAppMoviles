using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
    public int ActualScene; 
    //Variable para cambiar de escena
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Input que identfica cuando se presiona el mouse
        {
            ChangeScene();
        }
    }
    public void ChangeScene() //puse un Switch para verme mas pro :D atte: Sleekhell aka juan Alfredo
    {
        switch (ActualScene)
        {
            case 0:
                SceneManager.LoadScene("ArtekSync", LoadSceneMode.Single);
                break;
            case 1:
                SceneManager.LoadSceneAsync("ArtekAsyncrona");
                break;
            case 2:
                DontDestroyOnLoad(this.gameObject);
                SceneManager.LoadScene("ArtekDontDestroy");
                break;
          

        }
        
    }
}
