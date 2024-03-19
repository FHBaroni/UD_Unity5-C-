using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcoes : MonoBehaviour
{
    //tipo de retorno(materia prima) nome da função (argumentos, parametros,materiasa brutas)
    //{
    //}

    public int latidos;
    public int valorA, valorB;
    public int valor2, valor1;
    public float resultado;

    // Start is called before the first frame update
    void Start()
    {
        //SomarEImprimir(valorA, valorB);
        resultado = Multiplicar(valorA, valorB);
        print(resultado);
    }
    // void Latir()
    // {
    //     print("Whoof!" + latidos);
    //     latidos++;
    // }
    // Update is called once per frame
    void Update()
    {

    }
    void SomarEImprimir(float a, float b)
    {
        float soma = a + b;
        print("O resultado da soma é: " + soma);
    }

    float Multiplicar(float valor1, float valor2)
    {
        float multipicacao = valor1 * valor2;
        return multipicacao;
    }

}
