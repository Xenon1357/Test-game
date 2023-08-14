using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainFunction : MonoBehaviour
{
    [SerializeField] private Transform ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Chain.isFired = false;

        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.GetComponent<Bounciness>().Split();
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            Chain.isFired = false;
        }
    }
}