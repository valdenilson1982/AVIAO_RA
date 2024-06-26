using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnTelaInicial : MonoBehaviour
{

    public void IniciarJogo(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void Creditos(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void Sair()
    {
        Application.Quit();
    }

}
