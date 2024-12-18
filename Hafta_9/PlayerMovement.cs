using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    SpawnManager spawner;

    public float moveSpeed;
    public int life;

    public bool isSpeedBonusActive;
    public bool isDead;

    public GameObject leftEngine;
    public GameObject rightEngine;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        spawner = GameObject.FindWithTag("SpawnManager").GetComponent<SpawnManager>();
    }

    void Update()
    {
        if (!isDead)
        {
            moveSpeed = isSpeedBonusActive ? 100 : 50;

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, vertical, 0);
            rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);

            if (life <= 0)
            {
                spawner.StopAllCoroutines();
            }

            if (isSpeedBonusActive)
                Invoke(nameof(ChangeSpeedBonusrActive), 5f);

            if (life == 2)
                leftEngine.SetActive(true);

            if (life == 1)
                rightEngine.SetActive(true);


        }

        if (life <= 0)
        {
            isDead = true;
        }
    }

    private void ChangeSpeedBonusrActive()
    {
        isSpeedBonusActive = false;
    }
}
