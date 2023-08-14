using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 20f;

    // Update is called once per frame
    private void Update()
    {
        this.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}