using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{

    
    public int damage;
    public EntityHealth entityHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        /*if (other.CompareTag("Enemy"))
        {
            entityHealth = other.gameObject.GetComponent<EntityHealth>();
            entityHealth.Damage(damage);
        }    */

        if (other.CompareTag("Damageable"))
        {
            entityHealth = other.gameObject.GetComponent<EntityHealth>();
            entityHealth.Damage(damage);
        }  
    }
    


    /*
    public int damage;
    public EntityHealth entityHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Enemy"))
        {
            entityHealth = other.gameObject.GetComponent<EntityHealth>();
            entityHealth.HealthSystem.Damage(damage);
        }    
    }
    */
}
