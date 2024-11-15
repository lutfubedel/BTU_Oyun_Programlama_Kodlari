using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser;
    public GameObject tripleLaser;

    public bool canFire;
    public bool isTripleLaserActive;

    private void Update()
    {
        LaserFire();
    }

    private void LaserFire()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            if(!isTripleLaserActive)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(tripleLaser, transform.position, Quaternion.identity);
            }

            canFire = false; 
            Invoke(nameof(ChangeCanFire), 0.5f);

            if (isTripleLaserActive)
                Invoke(nameof(ChangeTripleLaserActive), 10f);
        }
    }

    private void ChangeCanFire()
    {
        canFire = true;
    }

    private void ChangeTripleLaserActive()
    {
        isTripleLaserActive = false;
    }
}
