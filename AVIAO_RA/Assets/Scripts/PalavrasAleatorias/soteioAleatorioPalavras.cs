using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soteioAleatorioPalavras : MonoBehaviour
{
    private bool isVerificarToque;

    public GameObject pista;
    public GameObject palavra;
    private montagemCompleta _montagemComplete;



    // Start is called before the first frame update
    void Start()
    {
        //pista.SetActive(false);
        // palavra.SetActive(false);
        _montagemComplete = FindObjectOfType(typeof(montagemCompleta)) as montagemCompleta;
    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                _montagemComplete.contador++;

                pista.SetActive(true);

                palavra.gameObject.transform.position = new Vector3(pista.transform.position.x,0f,pista.transform.position.z);
               
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
