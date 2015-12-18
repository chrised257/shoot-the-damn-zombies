using UnityEngine;
using System.Collections;

public class EnemyHealth : Health {
    public override void takeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            //Happily die.
            EnemySpawner.reportEnemyDead();
            Destroy(gameObject);
        }
    }
}
