using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGameManager : MonoBehaviour
{
    public Spawn spawner;
    public Rotate rot;
    private bool endGame = false;

    public void GameEnd()
    {
        if (endGame == false)
        {
            return;
        }
        else
        {
            spawner.enabled = false;
            rot.enabled = false;
            endGame = true;
        }
    }
}