using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public float speed = 15f;


    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rigidbody2d.velocity = transform.right * speed;
    }

    //Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1.5f);
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    } 
}
