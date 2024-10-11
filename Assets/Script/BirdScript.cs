using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
   public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AudioManager.singleton.PlaySound(0);
                myRigidbody.velocity = Vector2.up * flapStrength;
            }

            if (transform.position.y > 25 || transform.position.y < -25)
            {
                logic.gameOver();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}