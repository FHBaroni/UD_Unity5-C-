using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePontos : MonoBehaviour
{
    public int Pontos;
    // Start is called before the first frame update
    void Start()
    {
        NovaOnda();
    }

    // Update is called once per frame
    void NovaOnda()
    {
        Pontos += GameManager.Instancia.PontosPorOnda;
    }
}
