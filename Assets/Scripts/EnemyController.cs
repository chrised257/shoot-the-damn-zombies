using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour {

    public float attackDamage = 1.0f;
    public float attackRate = 1.5f;
    public float attackDistance = 1.5f;

    private Transform player;
    private NavMeshAgent navmeshAgent;
    private float timeUntilNextAttack = 0;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        navmeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
    void Update()
    {
        navmeshAgent.SetDestination(player.position);
    }

    void FixedUpdate()
    {
        if (timeUntilNextAttack > 0)
        {
            timeUntilNextAttack -= Time.deltaTime;
        }

        RaycastHit hit;
        if(timeUntilNextAttack <= 0 && Physics.Raycast(transform.position, transform.forward, out hit, attackDistance))
        {
            if(hit.transform.CompareTag("Player"))
            {
                hit.transform.SendMessageUpwards("takeDamage", attackDamage, SendMessageOptions.RequireReceiver);
                timeUntilNextAttack = attackRate;
            }
        }
    }
}
