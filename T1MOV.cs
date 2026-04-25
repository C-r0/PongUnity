using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1MOV : MonoBehaviour
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
        Mov(); // Chamei a funçao Mov()
    }

    // Funçao Mov
    void Mov() 
    {
        // Pega o VerticalWS e multiplica pela velocidade colocando na variavel Mov
        float Mov = Input.GetAxis("VerticalWS") * speed;

        // Faz contar por metro por segundo ao inves por frame
        Mov *= Time.deltaTime;

        // Faz a movimentaçao do objeto (Y)
        transform.Translate(0, Mov, 0);
    }
}