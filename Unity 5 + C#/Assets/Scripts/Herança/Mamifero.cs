using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mamifero : Animal
{
    public Color CorDoPelo;
    public Mamifero(Color corDoPelo, string especie, int idade) : base(especie, idade)
    {
        CorDoPelo = corDoPelo;

    }
    public void Mamar()
    {
        MonoBehaviour.print("O mamífero está mamando");
    }

    public override void Locomover()
    {
        MonoBehaviour.print("Locomovendo como mamífero");//implementação custonmizada
        base.Locomover();//implementação genérica

    }
}
