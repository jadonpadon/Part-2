using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private float timer = 0;
    public float spawnRate = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            float spawnX = Random.Range(-10, 10);
            float spawnY = Random.Range(-10, 10);
            Instantiate(enemy, new Vector3(spawnX, spawnY, 0), transform.rotation);

            timer = 0;
        }
    }
}
