using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class respostas : MonoBehaviour
{

    public int Respostas;
    public int numResposta;

    


    public void respostaCorreta(int respostaC)
    {
        Respostas += respostaC;
 

    }


    public void proximaCena(string nome)
    {
        SceneManager.LoadScene(nome);

    }

    public void NumeroResposta(int numero)
    {
        numResposta = numero;
    }

}
