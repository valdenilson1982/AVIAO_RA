using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parteMontada : MonoBehaviour
{


    public int contador;

    private montagemCompleta _montagemComplete;

    void Start()
    {
        _montagemComplete = FindObjectOfType(typeof(montagemCompleta)) as montagemCompleta;
    }

    
    void Update()
    {
       
    }

    public void Asa_L_Montada()
    {
        // _montagemComplete.contador++;
    }

    public void Asa_R_Montada()
    {
      //  _montagemComplete.contador++;
    }

    public void Frente_Montada()
    {
       // _montagemComplete.contador++;
    }

    public void Fundo_Montada()
    {
      //  _montagemComplete.contador++;
    }

    public void Rabo_Montada()
    {
       // _montagemComplete.contador++;
    }

    public void Rabo_L_Montada()
    {
       // _montagemComplete.contador++;
    }

    public void Rabo_R_Montada()
    {
      //  _montagemComplete.contador++;
    }

}
