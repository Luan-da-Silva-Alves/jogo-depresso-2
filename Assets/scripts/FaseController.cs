using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaseController : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Quarto")
        {
            SceneManager.LoadScene("Quarto");

            transform.position = new Vector3(-6.0f, 0.83f, 0);
        }

        if (collision.gameObject.tag == "Cozinha")
        {
            SceneManager.LoadScene("Cozinha");

            transform.position = new Vector3(-6.0f, 0.83f, 0);
        }

        if (collision.gameObject.tag == "Sala")
        {
            SceneManager.LoadScene("Banheiro");

            transform.position = new Vector3(-6.0f, 0.83f, 0);
        }

        if (collision.gameObject.tag == "Cozinha volta")
        {

             SceneManager.LoadScene("Cozinha");

             transform.position = new Vector3(7.47f, 1, 0);
        }


        if (collision.gameObject.tag == "Fora")
        {

            SceneManager.LoadScene("Fora");

            transform.position = new Vector3(-9.97f, 0.57f, 0);
        }
            
        
    }
}

    

