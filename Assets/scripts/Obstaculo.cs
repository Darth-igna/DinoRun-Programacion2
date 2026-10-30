using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Obstaculo : MonoBehaviour
{
    public float velocidad = 3f;
    public float TiempoInicio = 0f;
    public float TiempodeVidaMax = 10f;
   
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);
        TiempoInicio += Time.deltaTime;

        if (TiempoInicio >= TiempodeVidaMax)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player" + ""))
        {
            gameOver.instancia.ActivarGameOver();
            Debug.Log("Me mató: " + gameObject.name + " en " + transform.position);
            gameOver.instancia.ActivarGameOver();
        }
    }

}
