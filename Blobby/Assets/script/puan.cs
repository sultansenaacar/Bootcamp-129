using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puan : MonoBehaviour
{
    public static int puanlama = 0;
    private PlayerMovement kontrol;
    private timeSayac zamanayari;


    [SerializeField] private TextMeshProUGUI _score;
    public GameObject Win;

    [SerializeField] private Rigidbody2D _rb;


    private void Start()
    {
        kontrol = GetComponent<PlayerMovement>();
        zamanayari = GetComponent<timeSayac>();
        _score.text = puanlama.ToString("0");
        puanlama = 0;
    }
    private void Update()
    {
        if (puanlama == 75)
        {
            Win.gameObject.SetActive(true);
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hiz"))
        {
            kontrol.speed += 5;
            Invoke("oldSpeed", 10f);
        }

        if (other.gameObject.CompareTag("ziplama"))
        {
            kontrol.jumpingPower += 8;
            Invoke("oldJump", 6f);
        }

        if (other.gameObject.CompareTag("surekleme"))
        {
            time.times += 3;
        }

        if (other.gameObject.CompareTag("puan"))
        {
            puanlama++;
            Destroy(other.gameObject);
            _score.text = puanlama.ToString();



        }

        if (other.gameObject.CompareTag("tersyercekim"))
        {
            _rb.gravityScale = -4;
            Invoke("oldScale", 8f);
        }

        if (other.gameObject.CompareTag("ucma"))
        {
            _rb.gravityScale = -0.07f;
            Invoke("oldFly", 4f);
        }

        if (other.gameObject.CompareTag("eskihiz"))
        {
            kontrol.speed = 8;
            kontrol.jumpingPower = 16;
        }
    }

    



    private void oldSpeed()
    {
        kontrol.speed = 8;
    }

    private void oldJump()
    {
        kontrol.jumpingPower = 16;
    }


    private void oldScale()
    {
        _rb.gravityScale = 4;
    }

    private void oldFly()
    {
        _rb.gravityScale = 4;
    }

    public void Lvl3()
    {
       
    }
}
