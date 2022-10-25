using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private float movementSpeed = 3f;
    private Rigidbody rb;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * movementSpeed;
            thisAnimation.Play();
        }
            
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
