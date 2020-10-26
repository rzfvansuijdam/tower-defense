using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _startHealth = 3;
    public Slider slider;
    public GameObject healthBarUI;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    private void Update()
    {
     //   slider.value = CalculateHealth();

        slider.value = CalculateHealth();
        if (_currentHealth < _startHealth)
        {
            healthBarUI.SetActive(true);
        }
    }

    // Called from UnityEvent
    public void TakeDamage(float dmg = 3f)
    {

        _currentHealth -= dmg;
      //  print("Ik krijg schade...");

        if (_currentHealth <= 0)
        {
       //     print("Ik ben dood");
            Destroy(gameObject);
        }

    }

    float CalculateHealth()
    {
        return _currentHealth / _startHealth;
    }
}