using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject laser; // Ate� edilecek lazer nesnesi
    public bool canFire; // Ate� etme durumunu kontrol eden de�i�ken

    private void Update()
    {
        LaserFire(); // Her karede ate� fonksiyonunu kontrol eder
    }

    private void LaserFire()
    {
        // E�er "Space" tu�una bas�l�rsa ve ate� edilebiliyorsa
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            // Lazer nesnesini belirtilen pozisyonda olu�turur
            Instantiate(laser, transform.position, Quaternion.identity);

            canFire = false; // Ate� etme yetkisini kapat�r
            Invoke(nameof(ChangeCanFire), 2f); // 2 saniye sonra ate� etme yetkisini geri a�ar
        }
    }

    // Ate� edebilme yetkisini geri a�an fonksiyon
    private void ChangeCanFire()
    {
        canFire = true;
    }
}
