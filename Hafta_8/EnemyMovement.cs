using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    public GameObject enemy;

    private void Update()
    {
        transform.Translate(new Vector3(0, -1 * moveSpeed * Time.deltaTime, 0));

        if(transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }




    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().life -= 1;
            Destroy(this.gameObject);
        }
        if(other.CompareTag("Laser"))
        {
            UIManager uiManager = GameObject.FindWithTag("UIManager").GetComponent<UIManager>();
            uiManager.score += Random.Range(50, 100);

            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
