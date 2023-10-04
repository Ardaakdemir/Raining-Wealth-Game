using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GeriSayim : MonoBehaviour
{
    public TextMeshProUGUI Zaman;
    
    public AudioSource main;
    float suankiZaman =0f;
    float baslangicZamani = 30f;

    void Start()
    {
        main.Play();
            suankiZaman = baslangicZamani;
    }
    void FixedUpdate()
    {
        suankiZaman -= 1 *Time.deltaTime;

       if (suankiZaman <= 0)
       {
        suankiZaman = 0;
       }
        Zaman.text = suankiZaman.ToString("0");
       if (suankiZaman == 0)
       {
        
        Time.timeScale = 0f;
        main.Stop();
        SceneManager.LoadScene("OyunBitti");
        
       }

  
    }
}
