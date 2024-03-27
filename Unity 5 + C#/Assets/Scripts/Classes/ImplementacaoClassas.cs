using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImplementacaoClassas : MonoBehaviour
{
    public Carro carro1;
    public Carro carro2;


    //Use for initialization
    void Start()
    {
        carro1 = new Carro();// "Chevrolet", "Camaro", 2015, 300, 300);
        // *** Alocar espaço na memória para o objeto é opcional quando a classe é Serializável
        //  carro1 = new Carro();//aloca espaço na memoria para uma variavel(objeto) do tipo carro
        //carro1.fabricante = "Chevrolet";
        //carro1.modelo = "Camaro";
        //carro1.ano = 2015;
        //carro1.potencia = 300;
        //carro1.velocidadeMax = 300;
        carro1.SetarNumeroDeSerie();
        //print(carro1.LerNumeroDeSerie());//desativado por conta do GET
        print(carro1.NumeroDeSerie);


        carro2 = new Carro("Ford", "Fiesta", 2005, 110, 180, Carro.TipoDeCombustível.Alcool, true);
        ////   carro2 = new Carro();//alocar espaço na memoria para uma variavel do tipo carro
        //carro2.fabricante = "Ford";
        //carro2.ano = 2005;
        //carro2.potencia = 110;
        //carro2.modelo = "Fiesta";
        //carro2.velocidadeMax = 180;
        // print(carro2.LerNumeroDeSerie()); //desativado por conta do GET
        print(carro2.NumeroDeSerie);
        print("Carro 2 é mais potente que carro 1?" + carro2.MaisPotente(carro1));
        print("Um carro possui " + Carro.NumeroDeRodas + " Rodas.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
