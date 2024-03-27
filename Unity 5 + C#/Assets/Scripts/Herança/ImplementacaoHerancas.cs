using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImplementacaoHerancas : MonoBehaviour
{
    public Homem homem;
    public Cachorro cachorro;

    void Start()
    {
        homem = new Homem("João Batista", "Masculino", "Estudante", Color.black, "Homo Sapiens Sapiens", 17);
        cachorro = new("Alfredo", Color.black, 3);
        homem.Locomover();
        cachorro.Locomover();




        // print(homem.Especie);
        // homem.Locomover();
        // homem.Trabalhar();

        // homem.Idade = 17;
        // homem.Emprego = "estudante";
        // homem.Genero = "masculino";
        // homem.Nome = "João Batista";
        // homem.Especie = "Homo Sapiens Sapiens";
        // homem.CorDoPelo = Color.white;
    }

}
