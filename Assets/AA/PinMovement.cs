using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMovement : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;
    public bool isPinned = false;

    private void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            this.transform.SetParent(collision.gameObject.transform);
            isPinned = true;
            AAPlayerScore.i++;
        }
        if (collision.gameObject.CompareTag("Head"))
        {
            FindObjectOfType<AAGameManager>().GameEnd();
        }
    }
}