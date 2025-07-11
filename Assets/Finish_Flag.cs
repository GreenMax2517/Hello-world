using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Flag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Player"))
        {
            return;
        }
            GameManager.instance.StageClear();
            gameObject.SetActive(true);
            //Debug.Log(collision.name + "와 충돌함");
        }
    }