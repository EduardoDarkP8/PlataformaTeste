using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa1 : MonoBehaviour
{
    public float tamanho;
    public float massa;
    Rigidbody rg;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        Caixa cax = new Caixa(tamanho, massa);
        rg.mass = cax.massa;
        rg.transform.localScale = new Vector3(tamanho,tamanho,tamanho);
        Caixa.novaCaixa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
