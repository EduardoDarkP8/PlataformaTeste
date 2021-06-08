using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentar : MonoBehaviour
{
    public Vector3 pm;
    [Range(1.0f, 10.0f)] public float vertical = 5.0f;
    [Range(1.0f, 10.0f)] public float horizontalz = 5.0f;
    [Range(1.0f, 10.0f)] public float horizontalx = 5.0f;
    public float velocidadey;
    public float velocidadez;
    public float velocidadex;
    public bool v = false;
    public bool hx = false;
    public bool hz = false;
    // Start is called before the first frame update
    void Mover(Vector3 pm) 
    {
        transform.Translate(pm);
    }
    void Start()
    {
        pm.x = 0.0f;
        pm.y = 0.0f;
        pm.z = 0.0f;
       

    }

    // Update is called once per frame
    void Update()
    {
        if (v== true)
        {
            Movepositivov();
        }
        if (hx == true)
        {
            Movepositivohx();
        }
        if(hz == true)
        {
            Movepositivohz();
        }
    }
    public void Movepositivov()
    {
            vertical += velocidadey;
            pm.y = velocidadey;
            Mover(pm);
            pm.y = 0.0f;
        if (vertical >= 10.0f)
        
        {
            velocidadey = -velocidadey; 
        } 
        else if(vertical <= 0.0f)
        {
            velocidadey = -velocidadey;
        }
    }
    public void Movepositivohx()
    {
        horizontalx += velocidadex;
        pm.x = velocidadex;
        Mover(pm);
        pm.x = 0.0f;
        if (horizontalx >= 10.0f)

        {
            velocidadex = -velocidadex;
        }
        else if (horizontalx <= 0.0f)
        {
            velocidadex = -velocidadex;
        }
    }
    public void Movepositivohz()
    {
        horizontalz += velocidadez;
        pm.z = velocidadez;
        Mover(pm);
        pm.z = 0.0f;
        if (horizontalz >= 10.0f)

        {
            velocidadez = -velocidadez;
        }
        else if (horizontalz <= 0.0f)
        {
            velocidadez = -velocidadez;
        }
    }
}
