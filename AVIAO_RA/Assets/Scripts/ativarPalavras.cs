using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativarPalavras : MonoBehaviour
{
    public GameObject palavras;
    private fecharPainel _fechar;
    public int quant;
    void Start()
    {
        _fechar = FindObjectOfType(typeof(fecharPainel)) as fecharPainel;
    }

    // Update is called once per frame
    void Update()
    {

       

     if(quant ==7)
        {
            palavras.SetActive(true);
        }  
    }

    public void ativarPalavras1()
    {
        palavras.SetActive(true);
    }
}
