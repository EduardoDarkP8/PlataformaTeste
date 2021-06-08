using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ganhar : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // https://www.youtube.com/watch?v=XitFXRuO4DI&t=61s
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
            txt.enabled = true;
        }

    }
}
