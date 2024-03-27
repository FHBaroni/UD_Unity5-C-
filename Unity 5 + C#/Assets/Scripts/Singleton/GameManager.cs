using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//No Game Manager ficarão campos que são interresantes para os outros scripts
public class GameManager : MonoBehaviour
{
    public int NumeroMaximoDeInimigos;
    public float TempoMaximoDaOnda;
    public int NumeroMaximoDeOndas;
    public int PontosPorOnda;

    public static GameManager Instancia;
    // Start is called before the first frame update
    void Awake()
    {
        Instancia = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
