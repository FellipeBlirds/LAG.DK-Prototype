using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //https://www.youtube.com/watch?v=0T5ei9jN63M&ab_channel=CodeMonkey
    //https://www.youtube.com/watch?v=NE5cAlCRgzo&ab_channel=WayraCodes
    //esse script se comunica com HealthSystem, EntityHealth, HealthBar
    
    //public Image healthBar;

    private HealthSystem healthSystem;

    public void Setup(HealthSystem healthSystem)
    {
        this.healthSystem = healthSystem;
    }

    private void Update() 
    {
        //transform.Find("Health").localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
        //GameObject.Find("Health").fillAmount = healthSystem.GetHealthPercent();
        transform.Find("Bar").localScale = new Vector3 (healthSystem.GetHealthPercent(),1 );

        //fazer scripts para barra de vida UI e pra barra de vida gameobject, tipo encima da cabeça do boneco
    }

}
