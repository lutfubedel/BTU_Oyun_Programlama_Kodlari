using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float moveSpeed;

    private void Update()
    {
        transform.position += new Vector3(0, 1*moveSpeed*Time.deltaTime,0);
        Destroy(this.gameObject, 3f);
    }
}
