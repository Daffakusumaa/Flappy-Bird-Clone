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
        // Jika game over, hentikan update input
        if (!logic.gameOverScreen.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }

            if (transform.position.y > 18 || transform.position.y < -18)
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
