using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D playerRigidbody;
    private Vector2 playerDirection;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, 0).normalized;
    }

    void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector2(playerDirection.x * playerSpeed, 0);
    }


}
