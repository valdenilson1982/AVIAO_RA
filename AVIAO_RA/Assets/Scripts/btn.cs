using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    public GameObject paineisInformacoes;

    private void Start()
    {
        paineisInformacoes.SetActive(false);
    }

    public void fecharPainelInformacao()
    {
        paineisInformacoes.SetActive(true);
    }

}
