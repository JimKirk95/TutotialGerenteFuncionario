using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteUmFuncionario : MonoBehaviour
{
    public Funcionario funcionarioUm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Botao1()
    { funcionarioUm.Acao1(); }


    public void Botao2()
    { funcionarioUm.Acao2(); }

    public void Botao3()
    { funcionarioUm.Acao3(); }


}
