using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcoes1 : MonoBehaviour
{
    public int[] valores;
    public float valorQualquer;
    public float Dividendo, Divisor, Resto, Quociente;


    // Start is called before the first frame update
    void Start()
    {
        TrocarValorDeIndice(valores, 0, -3);
        SomarCom3(out valorQualquer);
        Quociente = Dividir(Dividendo, Divisor, ref Resto);

    }

    void TrocarValorDeIndice(int[] vetor, int indice, int valor)
    {
        vetor[indice] = valor;
    }

    void SomarCom3(out float numero)
    {
        numero = 0.0f;
        numero = numero + 3;// numero +=3;
    }


    int Dividir(float valor, float divisor, ref float resto)
    {
        //valor/divisor
        //resto = resto da divisão
        resto = 0;
        int quociente = 0;
        while (valor > 0)
        {
            if (valor - divisor > 0)
            {
                quociente++;
                valor = valor - divisor;
            }
            else
            {
                resto = valor;
                break;
            }
        }
        return quociente;
    }
}
