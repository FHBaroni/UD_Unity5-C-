using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais2IfElse : MonoBehaviour
{
    public bool podeBeber, idadeInvalida;
    public int idade;
    // Start is called before the first frame update
    void Start()
    {/*
        if (idade >= 18)
        {
            podeBeber = true;
        }
        else
        {
            podeBeber = false;
        }
     */
        if (idade >= 18 && idade <= 125)
        {
            podeBeber = true;
            idadeInvalida = false;
        }
        else if (idade < 0 || idade > 125)
        {
            podeBeber = false;
            idadeInvalida = true;
        }
        else
        {
            podeBeber = false;
            idadeInvalida = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
