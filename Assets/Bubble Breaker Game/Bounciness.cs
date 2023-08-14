using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounciness : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 startForce;
    [SerializeField] private GameObject nextBall;

    // Start is called before the first frame update
    private void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if (nextBall != null)
        {
            GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);
            ball1.GetComponent<Bounciness>().startForce = new Vector2(2f, 2f);
            ball2.GetComponent<Bounciness>().startForce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }
}