using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController control;
    public float speed = 6.0f; 

    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        control.Move((Vector3.forward * speed) * Time.deltaTime);

    }
}
