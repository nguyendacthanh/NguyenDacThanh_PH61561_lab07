using UnityEngine;

public class egg : MonoBehaviour
{
    Rigidbody2D rb;
    Animation animation;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float random = Random.Range(0.5f,2f);
        rb.gravityScale=random;
        animation = GetComponent<Animation>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chicken"))
        {
            Destroy(gameObject);
            Destroy(gameObject, 5f);
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
            
            
        }


    }
}
