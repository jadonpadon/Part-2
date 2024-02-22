using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionToCenter = Vector2.zero - (Vector2)transform.position;
        float distanceToCenter = directionToCenter.magnitude;
        Vector2 scaledDirection = directionToCenter * (speed / distanceToCenter);
        transform.Translate(scaledDirection * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        collision.gameObject.SendMessageUpwards("LoseHealth", 1, SendMessageOptions.DontRequireReceiver);
    }
    
}
