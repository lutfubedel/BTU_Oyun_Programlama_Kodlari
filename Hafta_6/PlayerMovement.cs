using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    SpawnManager spawner;

    public float moveSpeed;
    public float life;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawner = GameObject.FindWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0);
        rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);

        if(life <=0)
        {
            spawner.StopAllCoroutines();
        }
    }
}
