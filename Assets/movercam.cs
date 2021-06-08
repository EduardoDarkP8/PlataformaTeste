using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movercam : MonoBehaviour
{
    public float sen = 2.0f;
    public bool trav = true;
    public float MouseX = 0.0f;
    public float MouseY = 0.0f;
    public bool x = false, y = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        
     

        if (x == true)
        {
            MouseX += Input.GetAxis("Mouse X") * sen;
            transform.eulerAngles = new Vector3(0, MouseX, 0);
        }
        if (y == true)
        {
            MouseY -= Input.GetAxis("Mouse Y") * sen;
            transform.eulerAngles = new Vector3(MouseY, 0, 0);
        }

    }
}
