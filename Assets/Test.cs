using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 0.01f;

    bool isJumping = false;

    public int Jumpcount = 0;

    public float checkDistance = 0.55f;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += Time.deltaTime * Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += Time.deltaTime * Vector3.left * speed;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, checkDistance, LayerMask.GetMask("Ground"));
        isJumping = hit.collider == null;

        Debug.DrawRay(transform.position, Vector2.down * checkDistance, Color.red);

        if (!isJumping || Jumpcount < 2)
        {
            if (Jumpcount == 2)
                Jumpcount = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jumpcount += 1;

                // 힘을 위로 주는 코드

                rb.AddForce(Vector3.up * 5f, ForceMode2D.Impulse);
            }

        }
    }
}