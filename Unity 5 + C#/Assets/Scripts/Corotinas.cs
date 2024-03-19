using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corotinas : MonoBehaviour
{
    public float segundosEspera = 1;
    void Start()
    {
        StartCoroutine(CorrotinaBase());
    }
    //tipo de acesso - tipo de retorno - nome - parâmetros
    IEnumerator CorotinaTeste(float segundos)
    {
        //executa comandos
        //espera por alguns segundos
        //volta a executar comandos
        print("Comecei a executar uma corrotina");
        yield return new WaitForSeconds(segundos);
        print("Depois de " + segundos + " seg volto a executar a função");
    }
    IEnumerator CorotinaTeste1(float segundos)
    {
        print("Comecei a executar uma corrotina");
        float tempoAtual = 0;
        while (tempoAtual < segundos)
        {
            //passar para o próximo frame
            tempoAtual += Time.deltaTime;
            print("esperando");
            yield return new WaitForEndOfFrame();
        }
        print("Depois de " + segundos + " seg volto a executar a função");
    }
    //essa corroitna conta até dez e depois executa outra coisa
    IEnumerator CorrotinaBase()
    {
        print("Vou contar até 10...");
        yield return StartCoroutine(ContarAte10());

        int soma = 10 + 4;
        print("O resultado da soma é: " + soma);
    }
    IEnumerator ContarAte10()
    {
        for (int i = 1; i <= 10; i++)
        {
            print(i);
            yield return new WaitForSeconds(1);

        }
    }
}

