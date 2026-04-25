using UnityEngine;

public class BALL : MonoBehaviour
{
    // Variaveis
    public float speed = 1f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        launch();
    }

    private void launch()
    {
        float x = Random.Range(-2f, 2f);  // Corrigido para gerar aleatoriamente entre -1 e 1
        float y = Random.Range(-2f, 2f);  // Corrigido para gerar aleatoriamente entre -1 e 1
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position = new Vector2(0, 0);
        }
    }
}
