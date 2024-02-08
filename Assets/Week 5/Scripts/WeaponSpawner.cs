using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject weapon;
    public float axeMin = -5;
    public float axeMax = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnWeapon()
    {
        Instantiate(weapon, new Vector3(-10, Random.Range(axeMin, axeMax), 0), transform.rotation);
    }
}
