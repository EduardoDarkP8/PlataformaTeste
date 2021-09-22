using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa 
{
    public float tamanho { get; set; }
    public float massa { get; set; }
    
    public static int instancia = 0;


    public Caixa(float tamanho, float massa) 
    {

        this.tamanho = tamanho;
        this.massa = massa;
        instancia += 1;

    }

    public static void novaCaixa() 
    {
        
        Debug.Log("Exitem " + instancia.ToString() + "Caixas");
    }

    
    
}
