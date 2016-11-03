using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth = 10.0f;
    public int scoreValue = 1;

    protected float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //Happily die.
            EnemySpawner.reportEnemyDead();
            FindObjectOfType<Score>().AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
