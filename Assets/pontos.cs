using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pontos : MonoBehaviour
{
   
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player") 
        {
            Destroy(this.gameObject);
            
        }
    }
    
    
    
 }
