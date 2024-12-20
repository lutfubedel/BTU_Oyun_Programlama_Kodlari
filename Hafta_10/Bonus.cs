using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{

    public float moveSpeed;
    public int bonusID;

    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

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
        if(bonusID == 1)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<Fire>().isTripleLaserActive = true;
                source.Play();
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(this.gameObject,2f);
            }
        }

        else if (bonusID == 2)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerMovement>().isSpeedBonusActive = true;
                source.Play();
                GetComponent<SpriteRenderer>().enabled = false;
                Destroy(this.gameObject,2f);
            }
        }

    }
}
