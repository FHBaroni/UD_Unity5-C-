using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[System.Serializable]
public class Carro
{
    public enum TipoDeCombustível
    {
        Gasolina,
        Alcool,
        Diesel
    }
    public string Fabricante;
    public string Modelo;
    public int Ano;
    public int Potencia;
    public int VelocidadeMax;
    private string _numeroDeSerie;
    public TipoDeCombustível Combustivel;
    public bool Poluente;
    private static int _NumeroDeRodas = 4;
    public static int NumeroDeRodas
    {
        get { return _NumeroDeRodas; }
        //set
        //{
        //    if (value != 4)
        //    {
        //        MonoBehaviour.print("numero de rodas inválido");
        //    }
        //    _NumeroDeRodas = value;
        //}
    }


    public string NumeroDeSerie
    {
        get { return _numeroDeSerie; }
    }

    public Carro(string fabricante, string modelo, int ano, int potencia, int velocidadeMax, TipoDeCombustível combustível)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Ano = ano;
        Potencia = potencia;
        VelocidadeMax = velocidadeMax;
        Combustivel = combustível;
        SetarPoluenteSwich();
    }

    public Carro(string fabricante, string modelo, int ano, int potencia, int velocidadeMax, TipoDeCombustível combustível, bool setarNumeroDeSerie)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Ano = ano;
        Potencia = potencia;
        VelocidadeMax = velocidadeMax;
        Combustivel = combustível;
        if (setarNumeroDeSerie)
        {
            SetarNumeroDeSerie();
        }
        SetarPoluenteSwich();
    }

    public Carro()
    {
        Fabricante = "";
        Modelo = "";
        Ano = 0;
        Potencia = 0;
        VelocidadeMax = 0;
        Combustivel = TipoDeCombustível.Gasolina;
        SetarPoluenteSwich();
    }

    private void SetarPoluenteIf()
    {
        if (Combustivel == TipoDeCombustível.Alcool)
        {
            Poluente = false;
        }
        else if (Combustivel == TipoDeCombustível.Diesel || Combustivel == TipoDeCombustível.Gasolina)
        {
            Poluente = true;
        }
    }

    private void SetarPoluenteSwich()
    {
        switch (Combustivel)
        {
            case TipoDeCombustível.Alcool: Poluente = false; break;
            case TipoDeCombustível.Diesel: case TipoDeCombustível.Gasolina: Poluente = true; break;
            default: break;
        }
    }

    public void SetarNumeroDeSerie()
    {
        _numeroDeSerie = Ano.ToString() + Potencia.ToString() + VelocidadeMax.ToString();
    }

    //public string LerNumeroDeSerie()
    //{
    //    return _numeroDeSerie;
    //}

    public bool MaisPotente(Carro carroComparado)
    {
        return Potencia > carroComparado.Potencia;
    }

    //public static int LerNumeroDeRodas() // se tornou redundante devido ao get
    //{
    //    return _NumeroDeRodas;
    //}
}
