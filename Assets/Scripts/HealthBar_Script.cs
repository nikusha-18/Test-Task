using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Script : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    public float MaxHealth = 100f;
    Box box;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        box = FindObjectOfType<Box>();
    }

    private void Update()
    {
        CurrentHealth = box.healthCurrent;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
