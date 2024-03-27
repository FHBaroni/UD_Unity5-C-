using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Homem : Mamifero
{
    public string Nome;
    public string Genero;
    public string Emprego;

    public Homem(string nome, string genero, string emprego, Color corDoPelo, string especie, int idade) : base(corDoPelo, "Homo Sapiens Sapiens", idade)
    {
        Nome = nome;
        Genero = genero;
        Emprego = emprego;

    }
    public void Trabalhar()
    {
        if (Idade > 18)
        {
            MonoBehaviour.print(Nome + " está trabalhando");
        }
        else
        {
            MonoBehaviour.print(Nome + " é menor de id ade");

        }
    }

    public void Estudar()
    {
        MonoBehaviour.print(Nome + " está estudando");
    }
    public override void Locomover()
    {
        MonoBehaviour.print("Andando como Homem");//implementação custonmizada
        base.Locomover();//implementação genérica
    }
}
