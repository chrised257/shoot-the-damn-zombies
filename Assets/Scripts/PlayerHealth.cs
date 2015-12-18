using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : Health {

    public Text dieLabel;

    protected override void Start()
    {
        base.Start();
        dieLabel.gameObject.SetActive(false);
    }

    public override void takeDamage(float damage)
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
