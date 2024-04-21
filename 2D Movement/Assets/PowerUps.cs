using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerupPrefabs;
    public float spawnInterval = 7f; 

    void Start()
    {
        StartCoroutine(SpawnPowerup());
    }

    IEnumerator SpawnPowerup()
    {
        while (true) 
        {
            int randomIndex = Random.Range(0, powerupPrefabs.Length); 
            Vector3 spawnPosition = new Vector3(Random.Range(0, 10), Random.Range(0, 5), 0); 

            GameObject powerupObject = Instantiate(powerupPrefabs[randomIndex], spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject); 
        }
    }
}
