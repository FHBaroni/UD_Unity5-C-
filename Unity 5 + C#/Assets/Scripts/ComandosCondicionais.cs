using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosCondicionais : MonoBehaviour
{
    public bool condition;
    public int age;
    // alterar os valores de age e condition(que são public) no editor 
    void Start()
    {
        if (condition)
        {
            age = 0;
        }
    }
}
