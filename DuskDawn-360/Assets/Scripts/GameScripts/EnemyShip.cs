using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    private Vector2 screenLimit;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
        screenLimit = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenLimit.x * 2)
        {
            Destroy(this.gameObject);
        }
    }
}
