using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 10f;
    public float xMin, xMax , yMin, yMax;
    private float horizontal, vertical;
    private Rigidbody2D shipPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 newVelocity = new Vector2(horizontal, vertical);
        shipPlayer = GetComponent<Rigidbody2D>();
        shipPlayer.velocity = newVelocity * playerSpeed;


        float newX, newY;

        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, xMin, xMax);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, yMin, yMax);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);


    }


}
