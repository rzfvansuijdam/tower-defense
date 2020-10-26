using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
public class EnemyHealth : Health
{
    public Slider slider;
    public GameObject healthBarUI;
    void Start()
    {
        _startHealth = 3;
  //      health = _starthealth;

        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();
        if (health < starthealth)
        {
            healthBarUI.SetActive(true);
        }


        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    float CalculateHealth()
    {
        return health / starthealth;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("bullet"))
        {
            TakeDamage(25);
        }
    }
}


*/