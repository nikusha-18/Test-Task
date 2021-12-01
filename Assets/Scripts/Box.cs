using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private float healthInitial = 100f;
    public float healthCurrent;

    private float countdown = 1f;

    void Start()
    {
        ResetHealth();
    }

    public void ResetHealth()
    {
        healthCurrent = healthInitial;
    }

    public void TakeDamage(float damageAmount)
    {
        healthCurrent -= damageAmount;

        if (healthCurrent <= 0f)
        {
            ResetHealth();
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "NPC")
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                TakeDamage(5f);
                countdown = 1f;
            }
        }
    }

    void Update()
    {
        Debug.Log(healthCurrent);
    }
}
