using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{

    private void Start()
    {
        starthealth = 100;
        health = starthealth;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(25);
            Debug.Log("u dying bruv");
        }

    }

    public void Update()
    {

        if (health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("uded");
        }
    }

}
