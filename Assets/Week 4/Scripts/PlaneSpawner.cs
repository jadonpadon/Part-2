using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    public GameObject plane;
    public float spawnRateMax = 5;
    public float spawnRateMin = 1;
    public float spawned = Random.Range(1, 5);
    private float timer = 0;
    public float max = 5;
    public float min = -5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawned)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPlane();
            timer = 0;
        }
        
    }

    void spawnPlane()
    {
        Instantiate(plane, new Vector3(Random.Range(min, max), Random.Range(min, max), 0), Random.rotation);
    }
}
