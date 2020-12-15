using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteTresFuncionarios : MonoBehaviour
{
    public Funcionario funcionarioUm;
    public Funcionario funcionarioDois;
    public Funcionario funcionarioTres;

    public int FuncionarioDaVez = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Botao1()
    { //Aciona Acao1 do funcionario e volta um funcionario
        if (FuncionarioDaVez == 3)
        {
            funcionarioTres.Acao1();
            FuncionarioDaVez = 2;
        }
        else
        {
            if (FuncionarioDaVez == 2)
            {
                funcionarioDois.Acao1();
                FuncionarioDaVez = 1;
            }
            else
            {
                funcionarioUm.Acao1();
            }
        }    
    }


    public void Botao2()
    { //aciona acao 2 do funcionario, sem mudar o funcionário, usando swich

        switch (FuncionarioDaVez)
        {
            case 1:
                funcionarioUm.Acao2();
                break;
            case 2:
                funcionarioDois.Acao2();
                break;
            case 3:
                funcionarioTres.Acao2();
                break;
            default:
                break;
        }

     }

    public void Botao3()
    {
        //aciona acao 3 do funcionario e vai um funcinário para frente, usando swich

        switch (FuncionarioDaVez)
        {
            case 1:
                funcionarioUm.Acao3();
                break;
            case 2:
                funcionarioDois.Acao3();               
                break;
            case 3:
                funcionarioTres.Acao3();
                break;
            default:
                break;
        }
        FuncionarioDaVez++;
        if (FuncionarioDaVez > 3)
        { FuncionarioDaVez = 3; }

    }

}
