using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dashBoard : MonoBehaviour
{
    private gerenciarRespostas _respontasTotal;
  
    public Image img;
    public float percentualRespotas1;


    void Start()
    {
        _respontasTotal = FindObjectOfType(typeof(gerenciarRespostas)) as gerenciarRespostas;
    }

    // Update is called once per frame
    void Update()
    {

        if(_respontasTotal.numeroResposta == 1)
        {
            percentualRespotas1 = _respontasTotal.respostaAtulazadas1/2;
            img.fillAmount = percentualRespotas1;
        }
        

        
       
    }
}
