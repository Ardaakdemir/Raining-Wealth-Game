using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Carpisma : MonoBehaviour
{
  public static int puan;
  public TextMeshProUGUI puanyazi;
  public AudioSource trink;
  public Transform bu;
  
 void Start()
 {
  puan = 0;
  float xeksen = Random.Range(-8.42f,8.45f);
  float yeksen = Random.Range(6.05f,11f);
        transform.position = new Vector3(xeksen,yeksen,0f);
 }
 void Update()
  {
    puanyazi.text = "Score "+puan;
  }
   void OnCollisionEnter2D (Collision2D Temas)
   {
    float xeksen = Random.Range(-8.42f,8.45f);
    float yeksen = Random.Range(6.05f,11f);
    
    if(Temas.gameObject.tag == "Sandik")
    {
      bu.position = new Vector3 (xeksen, yeksen, 0f);
      puan += 10;
      trink.Play();
    }
    else if(Temas.gameObject.tag == "Cubuk")
    {
      bu.position = new Vector3 (xeksen, yeksen, 0f);
      puan -= 50;
      
    }

   }
   
}

