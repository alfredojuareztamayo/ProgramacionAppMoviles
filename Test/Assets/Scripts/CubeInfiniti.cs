using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeInfiniti : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Corutine;
    public GameObject Prefab;
    private int RandomColor;
    void Start()
    {
       // transform.rotation = Quaternion.identity;
        Corutine = InfinitCube(1f);
        StartCoroutine(Corutine);

       

       
       // rend.material.shader = Shader.Find("CubeSpam");
       

    }

    IEnumerator InfinitCube(float seconds)
    {

        yield return new WaitForSeconds(seconds);
        NewColor();
        Instantiate(Prefab, new Vector3(0,0,0), Quaternion.identity);
        Object.Destroy(Prefab, 5f);
       

    }

    // Update is called once per frame
    void Update()
    {
    

    }
    public void NewColor()
    {
        Renderer rend = GetComponent<Renderer>();
        RandomColor = Random.Range(1, 4);

        switch (RandomColor)
        {
            case 1:
                rend.material.SetColor("_Color", Color.red);
                break;
            case 2:
                rend.material.SetColor("_Color", Color.blue);
                break;
            case 3:
                rend.material.SetColor("_Color", Color.green);
                break;
        }
    }

}
