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
            Instantiate(enemy, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().life -= 1;
            Instantiate(enemy, new Vector3(Random.Range(-8.5f,8.5f),6.5f,0), Quaternion.identity);
            Destroy(this.gameObject);
        }
        if(other.CompareTag("Laser"))
        {
            Instantiate(enemy, new Vector3(Random.Range(-8.5f, 8.5f), 6.5f, 0), Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
