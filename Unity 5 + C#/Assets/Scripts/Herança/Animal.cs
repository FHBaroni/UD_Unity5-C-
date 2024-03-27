using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public string Especie;
    public int Idade;
    public Animal(string especie, int idade)
    {
        Especie = especie;
        Idade = idade;
    }
    //    public abstract void Locomover();
    public virtual void Locomover()
    {
        MonoBehaviour.print("Movendo-se como um animal - Forma genérica");

    }
    public void Comer()
    {
        MonoBehaviour.print("O animal está comendo");
    }


}
