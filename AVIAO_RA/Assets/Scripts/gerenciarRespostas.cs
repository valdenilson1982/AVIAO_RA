using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerenciarRespostas : MonoBehaviour
{
    private respostas _respostas;
    public int respostaAtulazadas1;
    public int respostaAtulazadas2;
    public int respostaAtulazadas3;
    public int respostaAtulazadas4;
    public int respostaAtulazadas5;
    public int numeroResposta;
    public int respota1;
    
    void Start()
    {
        

        _respostas = FindObjectOfType(typeof(respostas)) as respostas;

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if(_respostas.numResposta == 1)
        {
            respostaAtulazadas1 = _respostas.Respostas;
            numeroResposta = 1;
        }
        if(_respostas.numResposta == 2)
        {
            respostaAtulazadas2 = _respostas.Respostas;
            numeroResposta = 2;
        }
        if (_respostas.numResposta == 3)
        {
            respostaAtulazadas3 = _respostas.Respostas;
            numeroResposta = 3;
        }
        if (_respostas.numResposta == 4)
        {
            respostaAtulazadas4 = _respostas.Respostas;
            numeroResposta = 4;
        }
        if (_respostas.numResposta == 5)
        {
            respostaAtulazadas5 = _respostas.Respostas;
            numeroResposta = 5;
        }

    }
}
