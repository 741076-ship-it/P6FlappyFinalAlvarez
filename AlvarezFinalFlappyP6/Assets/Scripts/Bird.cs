using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upforce = 200f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<RigidBody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForc (new Vector2(0, upforce));
            }
        }
    }
}
