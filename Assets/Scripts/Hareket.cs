using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Hareket : MonoBehaviour
{
    public float HareketHizi;
    public GameObject Pausepanel;
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
           
            transform.Translate(-HareketHizi*Time.deltaTime,0f,0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(HareketHizi*Time.deltaTime,0f,0f);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
    {
        Pausepanel.SetActive(true);
        Time.timeScale = 0f;
    }   
        float PozisyonX = transform.position.x;
        PozisyonX = Mathf.Clamp(PozisyonX, -7.78f , 7.73f);
        transform.position = new Vector2(PozisyonX, transform.position.y);
        
    }
    

}
