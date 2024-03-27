using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cachorro : Mamifero
{
    public string Nome;

    public Cachorro(string nome, Color corDoPelo, int idade) : base(corDoPelo, "Canis lupus familiares", idade)
    {

        Nome = nome;
    }

    public void Latir()
    {
        MonoBehaviour.print("Auf");
    }

    public override void Locomover()
    {
        MonoBehaviour.print("Andando como cachorro");//implementação custonmizada
        base.Locomover();//implementação genérica

    }

}
