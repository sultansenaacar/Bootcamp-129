using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeSayac : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timesure;
    public GameObject gameover;
    

    private void Start()
    {
       
        InvokeRepeating("sure_azalt", 0.0f, 1.0f);

        timesure.text = time.times.ToString();
    }

    void sure_azalt()
    {
        
        time.times--;
        timesure.text = time.times.ToString();

        if (time.times == 0)
        {
            gameover.gameObject.SetActive(true);
            CancelInvoke("sure_azalt");
        }
    }
}
