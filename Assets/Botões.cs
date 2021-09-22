using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botões : MonoBehaviour
{

    public void sair()
    {
        Application.Quit();
    }
    public void start()
    {
        SceneManager.LoadScene(1);
    }
}
