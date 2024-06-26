using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acaoConcluirAnimacao : MonoBehaviour
{
    public GameObject painelInfo;

    private void Start()
    {
        painelInfo.SetActive(false);
    }

    public void exibirPainel()
    {
        painelInfo.SetActive(true);
    }

    
}
