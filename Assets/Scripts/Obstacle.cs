using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{
    // if 0 then move right
    // else move left
    private int movement;

    public float moveSpeed = 2.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        movement = Random.Range(0, 2);

    }

    // Update is called once per frame
    void Update()
    {
        if(tag == "MovingObstacle")
        {
            if(movement == 0)
            {
                MovePlayerRight();
            }
            else
            {
                MovePlayerLeft();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DestroyBorder")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
            // Get the current scene
            Scene currentScene = SceneManager.GetActiveScene();

            // Reload the current scene
            SceneManager.LoadScene(currentScene.name);


        }
        if (tag == "MovingObstacle")
        {
            if (collision.tag == "LeftBorder")
            {
                movement = 0;
            }
            else if (collision.tag == "RightBorder")
            {
                movement = 1;
            }
        }
        
    }


    void MovePlayerRight()
    {
        // Move player to the right
        transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }

    void MovePlayerLeft()
    {
        // Move player to the right
        transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }

}
