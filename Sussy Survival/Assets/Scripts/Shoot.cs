using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    Rigidbody2D rigidbody2d;

    Vector2 lookDirection = new Vector2(1, 0);

    private Transform firePoint;
    private float launchForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();

        var projectileInstance = Instantiate(
            projectilePrefab,
            firePoint.position,
            firePoint.rotation);
        projectileInstance.AddForce(firePoint.forward * launchForce);
    }
}
