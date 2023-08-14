using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAPlayerScore : MonoBehaviour
{
    public static int i;

    // Start is called before the first frame update
    private void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        print(i);
    }
}