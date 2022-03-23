using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public GameObject hitFX;

    private void Start() 
    {
        Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        GameObject fx = Instantiate(hitFX, transform.position, Quaternion.identity);
        Destroy(fx, 0.1f);
        Destroy(gameObject);
    }

}
