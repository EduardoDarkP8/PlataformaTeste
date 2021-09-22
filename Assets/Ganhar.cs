using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ganhar : MonoBehaviour
{
    public Text txt;
    public GameObject Player;
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
            Destroy(Player);
            txt.enabled = true;
            SceneManager.LoadScene(0);

        }

    }
 
}
