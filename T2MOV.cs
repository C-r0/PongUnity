using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2MOV : MonoBehaviour
{

    // Variaveis
    public float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mov(); // Chama a funçao Mov
    }

    // Funçao Mov
    void Mov() 
    {
        // Pega o VerticalKeys e multiplica pela variavel speed e armazena na variavel Mov
        float Mov = Input.GetAxis("VerticalKeys") * speed;

        // Muda de metros por frame para metros por segundo
        Mov *= Time.deltaTime;

        // Faz o bloco se mover
        transform.Translate(0, Mov, 0);
    }
}
