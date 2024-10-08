using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Rigidbody bileşeni için referans
    Rigidbody rb;

    // Hareket hızını kontrol eden değişkenler
    private float forwardSpeed;
    public float moveSpeed;

    // Script başlatıldığında çağrılır
    void Start()
    {
        // İleri hızı 10 olarak ayarlıyoruz
        forwardSpeed = 10;

        // Küp üzerine eklenmiş olan Rigidbody bileşenini alıyoruz
        rb = GetComponent<Rigidbody>();

        // Nesneyi başlangıçta X ekseninde 20 birim sağa taşıyoruz
        transform.position += new Vector3(20, 0, 0);
    }

    // Her karede bir kez çağrılır
    void Update()
    {
        // Yatay ve dikey girdi değerlerini al (varsayılan olarak yön tuşları veya WASD)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Eğer yatay ve dikey girdi sıfırsa (hiçbir tuşa basılmıyorsa)
        if (horizontal == 0 && vertical == 0)
        {
            // Nesneyi Z ekseninde ileri doğru hareket ettiriyoruz
            transform.position += new Vector3(0, 0, 1 * forwardSpeed * Time.deltaTime);
        }
        else
        {
            // Girdi değerlerine dayalı bir hareket vektörü oluşturuyoruz
            Vector3 movement = new Vector3(horizontal, 0, vertical);

            // Nesneyi girdiye, hareket hızına ve deltaTime'a göre hareket ettiriyoruz, böylece hareket akıcı olur
            rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
        }
    }
}
