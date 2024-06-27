using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montagemCompleta : MonoBehaviour
{
    private parteMontada _parteMontada;


    public int contador;


    public GameObject aviaoMontado;
    public GameObject aviaoDecolando;
    public GameObject[] palavras;
       

    void Start()
    {
        _parteMontada = FindObjectOfType(typeof(parteMontada)) as parteMontada;
    }

    // Update is called once per frame
    void Update()
    {

        if (contador == 7)
        {
            StartCoroutine(decolarAviao());
            for(int i = 0; i < palavras.Length; i++)
            {
                palavras[i].gameObject.SetActive(false);
            }
        }

    }

    IEnumerator decolarAviao()
    {
        yield return new WaitForSeconds(1.5f);
        aviaoDecolando.SetActive(true);
        aviaoMontado.SetActive(false);
    }
}
