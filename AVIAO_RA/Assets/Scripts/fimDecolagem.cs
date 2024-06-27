using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fimDecolagem : MonoBehaviour
{
    public GameObject aviao;
    public GameObject satisfacao;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fimAnimacaoAviao()
    {
        
        satisfacao.SetActive(true);
        Destroy(aviao.gameObject);
    }
}
