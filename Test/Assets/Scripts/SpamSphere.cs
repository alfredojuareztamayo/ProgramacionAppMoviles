using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamSphere : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator CorutineSphere;
    public GameObject Prefab;
    private int RandomColor;
    private int RandomScale;
    void Start()
    {
        // transform.rotation = Quaternion.identity;
        CorutineSphere = InfinitiSphere(2f);
        StartCoroutine(CorutineSphere);




        // rend.material.shader = Shader.Find("CubeSpam");


    }

    IEnumerator InfinitiSphere(float seconds)
    {

        yield return new WaitForSeconds(seconds);
       NewColor();
        NewScale();
        Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Object.Destroy(Prefab, 7f);


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
    public void NewScale()
    {
        RandomScale = Random.Range(0, 2);
        switch (RandomScale)
        {
            case 0:
                Prefab.transform.localScale = new Vector3(2f, 3f, 5f);
                break;
            case 1:
                Prefab.transform.localScale = new Vector3(1,1,1);
                Debug.Log("Holi");
                break;
        }
    }
}
