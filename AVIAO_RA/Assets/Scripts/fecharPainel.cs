using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fecharPainel : MonoBehaviour
{
    private bool isVerificarToque;
    public GameObject painel;
    private montagemCompleta _montagemComplete;

    private void Start()
    {
        _montagemComplete = FindObjectOfType(typeof(montagemCompleta)) as montagemCompleta;
    }
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButton("Fire1"))
            {
                _montagemComplete.contador++;
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
