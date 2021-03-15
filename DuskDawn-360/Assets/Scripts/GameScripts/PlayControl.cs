using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControl : MonoBehaviour
{
    public float playerSpeed = 3f;
    float horzDir = 0f;
    float vertDir = 0f;
    Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horzDir = Input.GetAxisRaw("Horizontal");
        vertDir = Input.GetAxisRaw("Vertical");
        // print("Dir = " + horzDir + "/" + vertDir);
    }

    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(horzDir * playerSpeed, vertDir * playerSpeed);
    }

}
