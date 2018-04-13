using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int startHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Image healthBar;

    bool isDead;
    bool damaged;

	// Use this for initialization
	void Start ()
    {
        currentHealth = startHealth;	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (counter < maxCounter)
        {
            counter += Time.deltaTime;
        }
        else
        {
            previousHealth = currentHealth;
            counter = 0;
        }
        //HealthBar Animation
        healthBar.fillAmount = Mathf.Lerp(previousHealth / maxHealth,
            currentHealth / maxHealth, counter / maxCounter);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        counter = 0;
        previousHealth = healthBar.fillAmount * startHealth;
        currentHealth -= dmg;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }

    }

    void Death()
    {
        isDead = true;

        //will be necessary to disable movement and flower giving abilites/effects
        //playerMovement.enabled = false;
        //playerFlowerGive.enabled = false;
        //need an animation for death (anim.SetTrigger("Die"); )
        //audio clip for death?
        
    }
}
