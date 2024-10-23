using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser; 
    public bool canFire;

    private void Update()
    {
        LaserFire();
    }

    private void LaserFire()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            Instantiate(laser, transform.position, Quaternion.identity);

            canFire = false; 
            Invoke(nameof(ChangeCanFire), 0.5f);
        }
    }

    private void ChangeCanFire()
    {
        canFire = true;
    }
}
