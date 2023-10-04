using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menuplex : MonoBehaviour
{
    public GameObject Panelim;
   
    public void Basla()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Resume()
    {
       Panelim.SetActive(false);
       Time.timeScale = 1f;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Oyun");
    }
}
