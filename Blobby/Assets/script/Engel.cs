using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    public Scene sahne;

    private void Awake()
    {
        sahne = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene(sahne.name);
        }
    }
}
