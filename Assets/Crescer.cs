using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crescer : MonoBehaviour
{
    Vector3 pm;
    public float velocidadey;
    public float velocidadez;
    public float velocidadex;
   

    // Start is called before the first frame update
    
    void Start()
    {
        pm = new Vector3(velocidadex, velocidadey, velocidadez);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.localScale += pm * Time.deltaTime;
        }
        if (Input.GetMouseButton(1))
        {
            transform.localScale -= pm * Time.deltaTime;
        }
    }
   
}
