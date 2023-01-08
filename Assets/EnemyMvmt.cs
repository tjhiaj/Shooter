using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMvmt : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Rigidbody2D playerRb; 

    private void Start()
    {
        playerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 lookDir = playerRb.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        rb.MovePosition(rb.position + lookDir.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
