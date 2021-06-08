using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// https://docs.unity3d.com/ScriptReference/CharacterController-isGrounded.html
public class gravidade : MonoBehaviour
{
    
    public float gravi;

    CharacterController contro;
    Vector3 cair;
    // Start is called before the first frame update
    void Start()
    {
        contro = GetComponent<CharacterController>();
    }
    void Cair(Vector3 cair) 
    {
        transform.Translate(cair);
    }

    // Update is called once per frame
    void Update()
    {
        if (!contro.isGrounded) 
        {
            cair.y = -gravi * Time.deltaTime;
            Cair(cair);
            cair.y = 0;
        }

    }
    
}
