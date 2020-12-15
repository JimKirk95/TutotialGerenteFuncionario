using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteListaFuncionarios : MonoBehaviour
{
    //Chamei de Lista, mas estou usando Array :-) dá quase na mesma, pode usar Lista
    public Funcionario[] funcionarios;

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
        funcionarios[FuncionarioDaVez-1].Acao1();
        FuncionarioDaVez --;
        if (FuncionarioDaVez < 1)
        { FuncionarioDaVez = 1; }
    }


    public void Botao2()
    { //aciona acao 2 do funcionario, sem mudar o funcionário
        funcionarios[FuncionarioDaVez-1].Acao2();
    }

    public void Botao3()
    {
        //aciona acao 3 do funcionario e vai um funcinário para frente
        funcionarios[FuncionarioDaVez-1].Acao3();
        FuncionarioDaVez++;
        if (FuncionarioDaVez > funcionarios.Length)
        { FuncionarioDaVez = funcionarios.Length; }

    }
}
