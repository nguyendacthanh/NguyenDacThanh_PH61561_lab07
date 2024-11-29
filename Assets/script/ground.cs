using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ground : MonoBehaviour
{
    public TextMeshProUGUI missTxt;
    private int miss = 0;
    public GameObject chicken;
    private static int dieuKienThua = 2;
    private bool checkDieuKien=false;
    private void Start()
    {
        missScore();
    }
    private void Update()
    {   

        if (checkDieuKien) {

            reloadScene();
            checkDieuKien = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("egg"))
        {
            miss++;
            missScore();
            Destroy(collision.gameObject);
            if (miss > dieuKienThua)
            {
                desstroychicken(chicken);
                dieuKienThua++;

                checkDieuKien = true;
            }
        }
    }
    private void missScore()
    {
        if (missTxt != null)
        {
            missTxt.text = "Miss: " + miss;
        }
    }
    private void desstroychicken(GameObject chicken) {
        Destroy(chicken);
    }

    void reloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    

}
