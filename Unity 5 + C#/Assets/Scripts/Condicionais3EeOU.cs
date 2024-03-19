using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais3EeOU : MonoBehaviour
{
    public bool compraAutorizada, idValida;
    public int idade;
    // Start is called before the first frame update
    void Start()
    {
        if (idade >= 19 || idade >= 40)
        {
            compraAutorizada = true;
        }
    }
}
