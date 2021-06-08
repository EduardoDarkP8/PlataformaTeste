using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtlPTS : MonoBehaviour
{
    public Text txt;
    public double Numpontos;
    // Start is called before the first frame update
    public void atualizar()
    {

            
            Numpontos += 50;
            txt.text = "Pontos: " + Numpontos;
     
    }
    void Start()
    {
        Numpontos = 0;
     

    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "pontos")
        {
            atualizar();
        }
    }
}
