using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float moveSpeed; // Lazerin hareket h�z�

    private void Update()
    {
        // Lazerin yukar� do�ru hareket etmesini sa�lar
        transform.position += new Vector3(0, 1 * moveSpeed * Time.deltaTime, 0);

        // Lazer nesnesini 3 saniye sonra yok eder
        Destroy(this.gameObject, 3f);
    }
}
