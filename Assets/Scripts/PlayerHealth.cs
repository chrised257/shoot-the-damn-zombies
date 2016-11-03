using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth = 10.0f;
    public Text dieLabel;

    protected float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        dieLabel.gameObject.SetActive(false);
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //Happily tell player he died.
            dieLabel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
