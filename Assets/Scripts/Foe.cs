using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Foe : MonoBehaviour
{
    [SerializeField]
    float Velocity;
    float diff = 0.5f;
    [SerializeField]
    Ball ball;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float targetY = ball.transform.position.y;

        if (transform.position.y < targetY - diff) {
            rb.velocity = new(0, Mathf.Lerp(rb.velocity.y, +Velocity, Time.deltaTime * 10));
        } else if(transform.position.y > targetY + diff) {
            rb.velocity = new(0, Mathf.Lerp(rb.velocity.y, -Velocity, Time.deltaTime * 10));
        } else {
            rb.velocity = new(Mathf.Lerp(0, rb.velocity.x, Time.deltaTime), Mathf.Lerp(0, rb.velocity.y, Time.deltaTime * 10));
            
        }
    }
}
