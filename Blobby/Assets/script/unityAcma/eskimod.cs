using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eskimod : MonoBehaviour
{
    private PlayerMovement karakter;

    [SerializeField] private Rigidbody2D charozellik;

    private void Start()
    {
        karakter = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            karakter.speed = 8;
        }
    }
}
