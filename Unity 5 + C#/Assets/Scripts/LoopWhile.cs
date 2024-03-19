using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int inteiro;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            print("o inteiro vale: " + inteiro);
            inteiro++;
        }
        while (inteiro < 100);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
