using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private Transform player;

    public static bool isFired = false;

    // Start is called before the first frame update
    private void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Movement.isMove)
        {
            isFired = true;
        }
        if (isFired)
        {
            transform.localScale += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}