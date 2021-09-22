using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa2 : MonoBehaviour
{
    private int tamanho = 6;
    private int massa = 9;
    Rigidbody rg;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
        Caixa cxa2 = new Caixa(tamanho, massa);
        rg = GetComponent<Rigidbody>();
        rg.mass = cxa2.massa;
        rg.transform.localScale = new Vector3(tamanho,tamanho,tamanho);
        Caixa.novaCaixa();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            player.transform.position = new Vector3(-17.96f, 1.73f, -8.17f);

        }
    }


}
