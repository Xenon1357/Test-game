using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float move = 0;
    [SerializeField] private Rigidbody2D rb;
    public static bool isMove = true;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        move = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(move * Time.fixedDeltaTime, 0f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            print("Game Over");
        }
    }
}