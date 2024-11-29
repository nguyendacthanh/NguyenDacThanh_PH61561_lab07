using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chicken : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed=20f;
    private int score=0;
    public TextMeshProUGUI scoreTxt;
    private static int dieuKienThang = 2;
    private bool checkDieuKien = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        updateScore();
    }
    private void Update()
    {
        movement.x= Input.GetAxisRaw("Horizontal");
        rb.MovePosition(rb.position+movement*moveSpeed*Time.deltaTime);
        if (checkDieuKien)
        {

            reloadScene();
            checkDieuKien = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("egg")) {
            score++;
            updateScore();
        }
        if (score == dieuKienThang)
        {
            dieuKienThang++;

            checkDieuKien = true;
        }
    }
    private void updateScore() {
        if (scoreTxt != null) {
            scoreTxt.text = "Score: " + score;
        }
    }
    private void desstroychicken(GameObject chicken)
    {
        Destroy(chicken);
    }

    void reloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
