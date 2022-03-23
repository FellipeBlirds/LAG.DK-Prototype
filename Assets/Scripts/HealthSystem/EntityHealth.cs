using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{
    //https://www.youtube.com/watch?v=0T5ei9jN63M&ab_channel=CodeMonkey
    //https://www.youtube.com/watch?v=NE5cAlCRgzo&ab_channel=WayraCodes
    //esse script se comunica com HealthSystem, EntityHealth, HealthBar

    HealthSystem healthSystem = new HealthSystem(100);

    public HealthBar healthBar;
    public int actualHealth;

    private void Start() 
    {

        healthBar.Setup(healthSystem);

        //Damage(10);
        //Debug.Log("Health: "+healthSystem.GetHealthPercent());
        
        //healthSystem.Damage(30);
        //Debug.Log("Health: "+healthSystem.GetHealthPercent());

    }

    private void Update() 
    {
        Debug.Log("Health: "+healthSystem.GetHealthPercent());
        actualHealth = healthSystem.GetHealth();
    }

    public void Damage(int damage)
    {
        healthSystem.Damage(damage);
        Debug.Log("Health: "+healthSystem.GetHealth());
    }

    public void Heal(int heal)
    {
        healthSystem.Heal(heal);
        Debug.Log("Health: "+healthSystem.GetHealth());
    }

}
