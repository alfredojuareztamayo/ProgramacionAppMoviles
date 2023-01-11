using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
    public int ActualScene;
    // Start is called before the first frame update
   
    void Start()
    {
     

        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
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
