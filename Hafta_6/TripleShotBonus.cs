using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotBonus : MonoBehaviour
{

    public float moveSpeed;

    private void Update()
    {
        transform.Translate(new Vector3(0, -1 * moveSpeed * Time.deltaTime, 0));

        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Fire>().isTripleLaserActive = true;
            Destroy(this.gameObject);
        }
    }
}
