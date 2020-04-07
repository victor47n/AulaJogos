using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    /* Criar variáveis globais de configuração do Unity */
    public float velocity;
    private Rigidbody body;

    void Start()
    {
        /* Atribuição do corpo rígido da bola a variável body */
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        /* O Pressionar das teclas para direita/esquerda */
        float movementH = Input.GetAxis("Horizontal");
        /* O pressionas das teclas para cima/baixo */
        float movementV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementH, 0.0f, movementV);

        /* Impulso: Quantidade de movimento -> Q = m * v */
        body.AddForce(movement * velocity);
    }

    void Update()
    {
        
    }
}
