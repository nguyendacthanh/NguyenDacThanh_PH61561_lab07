using System.Collections;
using UnityEngine;

public class machine :MonoBehaviour
{
    Vector2 trucX = new Vector2(-5f,5f);
    public GameObject egg;
    private void Start()
    {
        StartCoroutine(spawnEgg());
    }
    IEnumerator spawnEgg() {
        while (true) {
            float random = Random.Range(-5f, 5f);

            Vector3 spawnPosition = new Vector3(random, 14f, 0f);

            Instantiate(egg, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(2f);

        }
    }
}
