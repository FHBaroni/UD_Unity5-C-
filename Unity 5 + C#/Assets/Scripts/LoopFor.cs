using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopFor : MonoBehaviour
{
    public string[] textos;
    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 1; i <= 10; i++)
        // {
        //     int multiploDeTres = i * 3;
        //     print(multiploDeTres);
        // }



        // for (int i = 0; i < textos.Length; i++)
        // {
        //     print(textos[i]);
        // }

        foreach (string s in textos)
        {
            print(s);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
