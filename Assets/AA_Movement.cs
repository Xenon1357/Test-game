using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Movement : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed = 20f;
	public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position+ Vector2.up * speed * Time.deltaTime);
    }
}
