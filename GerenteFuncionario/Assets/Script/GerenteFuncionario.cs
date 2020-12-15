using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteFuncionario : MonoBehaviour
{
    private float velocidade = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localEulerAngles += Vector3.up * velocidade *Time.deltaTime;
    }


    public void Acao1()
    { velocidade = 180f; }


    public void Acao2()
    { velocidade = -180f; }

    public void Acao3()
    { velocidade = 0f; }


}
