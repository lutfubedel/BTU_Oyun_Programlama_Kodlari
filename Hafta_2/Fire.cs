using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser; // Ateþ edilecek lazer nesnesi
    public bool canFire; // Ateþ etme durumunu kontrol eden deðiþken

    private void Update()
    {
        LaserFire(); // Her karede ateþ fonksiyonunu kontrol eder
    }

    private void LaserFire()
    {
        // Eðer "Space" tuþuna basýlýrsa ve ateþ edilebiliyorsa
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            // Lazer nesnesini belirtilen pozisyonda oluþturur
            Instantiate(laser, transform.position, Quaternion.identity);

            canFire = false; // Ateþ etme yetkisini kapatýr
            Invoke(nameof(ChangeCanFire), 2f); // 2 saniye sonra ateþ etme yetkisini geri açar
        }
    }

    // Ateþ edebilme yetkisini geri açan fonksiyon
    private void ChangeCanFire()
    {
        canFire = true;
    }
}
