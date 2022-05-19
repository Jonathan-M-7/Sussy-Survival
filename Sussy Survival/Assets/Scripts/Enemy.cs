using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame*1
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    
}
