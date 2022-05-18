using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = .25f;
    private Rigidbody2D enemyRB;
    private GameObject player;
    public Transform playerObj;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame*1
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRB.AddForce(lookDirection * speed);

        transform.LookAt(playerObj);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
}
