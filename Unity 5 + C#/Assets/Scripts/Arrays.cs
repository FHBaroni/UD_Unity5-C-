using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public int[] arrayInteiros;
    public int valorQualquer;
    // Start is called before the first frame update
    void Start()
    {
        // arrayInteiros[0] = -3;
        // arrayInteiros[2] = 15;
        // valorQualquer = arrayInteiros[3];

        int posicaoVetor = 0;
        while (posicaoVetor <= (arrayInteiros.Length - 1))
        {
            arrayInteiros[posicaoVetor] = posicaoVetor * 2;
            posicaoVetor++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
