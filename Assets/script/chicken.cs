using TMPro;
using UnityEngine;

public class chicken : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed=20f;
    private int score=0;
    public TextMeshProUGUI scoreTxt;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        updateScore();
    }
    private void Update()
    {
        movement.x= Input.GetAxisRaw("Horizontal");
        rb.MovePosition(rb.position+movement*moveSpeed*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("egg")) {
            score++;
            updateScore();
        }
    }
    private void updateScore() {
        if (scoreTxt != null) {
            scoreTxt.text = "Score: " + score;
        }
    }
}
