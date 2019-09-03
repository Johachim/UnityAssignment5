using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x_auto = Time.deltaTime * speed;
        transform.Translate(x_auto, 0, 0);

    }
}
