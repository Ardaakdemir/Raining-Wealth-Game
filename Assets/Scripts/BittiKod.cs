using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BittiKod : MonoBehaviour
{
     public AudioSource BitisW,bitisL;
     public GameObject LosePanelim,WinPanelim;
     public TextMeshProUGUI LoseYazisi,Win;
    
    void Start()
    {
        
        if(Carpisma.puan <= 0)
        {
            bitisL.Play();
            LoseYazisi.text = "GAME OVER You Lose\nScore ="+Carpisma.puan+"\nPress Any Key To Restart";
            LosePanelim.SetActive(true);
            WinPanelim.SetActive(false);
        }
        else
        {
            BitisW.Play();
            Win.text = "GAME OVER You Win!\nScore ="+Carpisma.puan+"\nPress Any Key To Restart";
            WinPanelim.SetActive(true);
            LosePanelim.SetActive(false);
        }
        
    }
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }else 
            {
                Time.timeScale = 1f;
            SceneManager.LoadScene("Oyun");
            }
        }
    }

}
