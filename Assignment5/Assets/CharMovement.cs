using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 3f;
    public float jumpSpeed = 20f;
    public bool isGrounded = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x_auto = Time.deltaTime * speed;
        transform.Translate(x_auto, 0, 0);
        Jump();

    }

    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
        }
    }
}
