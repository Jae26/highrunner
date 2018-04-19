using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth = 100f;
    public static float currentHealth;
    public float previousHealth;
    public Image healthBar;

    public GameObject deathScreen;


	void Start ()
    {
        currentHealth = maxHealth;
	}
	
	void Update ()
    {
	    
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(50f);
        }
    }

    void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
        healthBar.fillAmount = currentHealth / maxHealth;
        
        if(currentHealth <= 0)
        {
            Death();
        }

    }

    void Death()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0f;

    }

}
