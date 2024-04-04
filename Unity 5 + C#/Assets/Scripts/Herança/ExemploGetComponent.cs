using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploGetComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Light luz = GetComponent<Light>();
        if (luz != null)
        {
        luz.intensity = 3.0f;
        luz.color = Color.red;
            
        }
        else
        {

            print("Não há luz acoplada no componente");
        }
        Invoke("ContinuarDepoisDeCincoSegundos", 5f);
      }

    void ContinuarDepoisDeCincoSegundos()
    {
        Debug.Log("Passaram-se 5 segundos");
        GetComponent<MeshRenderer>().enabled = false;      
    }

    // Update is called once per frame
    void Update()
    {

    }
}
