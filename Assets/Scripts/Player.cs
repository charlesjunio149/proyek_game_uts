using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool balik; 

    Rigidbody2D rb; 

    SpriteRenderer sp; 

    [SerializeField] 
    Transform CekGround; 

    [SerializeField] 
    int kecepatan; 

    [SerializeField] 
    int jarak; 


    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>(); 
        sp = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) 
        { 

            rb.velocity = new Vector2(0, kecepatan); 

            sp.flipY = false; 

        }else if (Input.GetKey("a")) 
        { 

            rb.velocity = new Vector2(-kecepatan, 0); 

            sp.flipX = false; 

        }else if (Input.GetKey("s"))
        { 

            rb.velocity = new Vector2(0, -kecepatan); 

            sp.flipY = false; 

        } 

        else if (Input.GetKey("d")) 

        { 

            rb.velocity = new Vector2(kecepatan, 0); 

            sp.flipX = false; 

        } 
    }

}
