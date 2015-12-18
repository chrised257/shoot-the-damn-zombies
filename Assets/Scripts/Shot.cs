using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Shot : MonoBehaviour {

    public float damage = 1.0f;
    public float shotspeed = 300.0f;
    public float maxDistance = 100.0f;

    private Vector3 initialPosition;

	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * shotspeed;
        initialPosition = transform.position;
	}

    void Update()
    {
        if ((transform.position - initialPosition).sqrMagnitude > (maxDistance * maxDistance))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(this.name + " touched an enemy! Kill him!!!");
            collision.gameObject.SendMessageUpwards("takeDamage", damage, SendMessageOptions.DontRequireReceiver);
        }

        Destroy(gameObject);
    }
}
