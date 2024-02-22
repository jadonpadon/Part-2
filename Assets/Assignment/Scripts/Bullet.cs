using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq.Expressions;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 movement;
    Vector2 destination;
    private Transform destinationTransform;
    bool shot = false;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destinationTransform = new GameObject("Destination").transform;
        destinationTransform.position = destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            shot = true;
            Debug.Log("shot");
        }
    }

        private void FixedUpdate()
        {
            movement = destination - (Vector2)transform.position;
            if (shot && movement.magnitude < 0.1)
            {
            movement = Vector2.zero;
            Destroy(gameObject);
            Debug.Log("destroyed");
            }
            rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
        }
    }

