using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fecharPainel : MonoBehaviour
{
    private bool isVerificarToque;
    public GameObject painel;
    private ativarPalavras cont;


    private void Start()
    {
       cont = FindObjectOfType(typeof( ativarPalavras)) as ativarPalavras;
    }
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                cont.quant++; 
               
                painel.SetActive(false);
                
            }
        }

    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }

}
