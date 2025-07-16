using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{

    public Transform SpawnPoint;

    public void Enter()
    {
        SpawnPoint.gameObject.SetActive(false);
        FindAnyObjectByType<Player>().transform.position = SpawnPoint.position;
        gameObject.SetActive(true);
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    
        Enter();
    
    }
}