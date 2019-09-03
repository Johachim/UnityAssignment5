using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBreak : MonoBehaviour
{

    public AudioSource PlingCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "CoinTag")
        {
            Destroy(collision.gameObject);    
        }
            PlingCoin.Play();
    }
}
