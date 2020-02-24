using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapForce;
    public GameObject gameoverUI;
    int score;
    public AudioSource flap;
    public AudioSource death;
    public AudioSource point;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("flap is working");

            //birdRigidbody.AddForce(Vector2.up * flapForce); (DO NOT TYPE) 
            birdRigidbody.velocity = Vector2.up * flapForce;
            flap.Play();
        }
    }

    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score Tag")
        {
            score += 1;
            point.Play();
            Debug.Log(score);
        }
        else
        {
            gameoverUI.SetActive(true);
            death.Play();
            Time.timeScale = 0;
        }
    }

    public void OnRestartButtonPressed ()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
