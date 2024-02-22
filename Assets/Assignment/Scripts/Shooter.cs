using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shooter : MonoBehaviour
{
    Rigidbody rb;
    public float health;
    public float maxHealth = 5;
    public GameObject bullet;
    public Transform spawn;
    bool died = false;
    public Button respawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !died)
        {
            Instantiate(bullet, spawn.position, spawn.rotation);

            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = clickPosition - (Vector2)transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x);
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Rad2Deg * angle);
        }

        respawn.interactable = died;
    }

    public void LoseHealth(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
    
        if(health <= 0)
        {
            died = true;
        }
        else
        {
            died = false;
        }

    }
}