using UnityEngine;
using System.Collections;

public abstract class Health : MonoBehaviour {

    public float maxHealth = 10.0f;

    protected float currentHealth;

	// Use this for initialization
	protected virtual void Start () {
        currentHealth = maxHealth;
	}

    public abstract void takeDamage(float damage);
}
