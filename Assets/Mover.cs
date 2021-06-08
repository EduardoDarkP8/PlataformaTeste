using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mover : MonoBehaviour
   
{
    public Vector3 m;
    Vector3 velocidade;
    Rigidbody rb;
    public bool teste = false;
    public float gravidade = 0;
    public bool noChao = false;
    public float velo = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        m.x = 0.0f;
        m.y = 0.0f;
        m.z = 0.0f;
        rb = GetComponent<Rigidbody>();
        


    }
    void mover(Vector3 m)
    {
        
        transform.Translate(m);
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W)) 
        {
            m.x = velo;
            mover(m);
            m.x = 0.0f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            m.x = -velo;
            mover(m);
            m.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            m.z = -velo;
            mover(m);
            m.z = 0.0f;
        }
        if(Input.GetKey(KeyCode.A))
        {
            m.z = velo;
            mover(m);
            m.z = 0.0f;
        }
        
        if (Input.GetKey(KeyCode.Space) && noChao == true)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 325,0));
            noChao = false;
        }
     

}

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "chao" || collision.gameObject.tag == "pontos")
        {
            noChao = true;

        }
        else
        {
            noChao = false;
        }
        if (collision.gameObject.tag == "chaom")
        {
            
            transform.position = new Vector3(-17.96f, 1.73f, -8.17f);
            
        }

    }
    
    
}
