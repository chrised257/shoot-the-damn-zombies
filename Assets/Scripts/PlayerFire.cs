using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {

    public Shot shotPrefab;
    public float fireRate = 0.3f;
    public Transform shotsOrigin;

    public float reloadTime = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        reloadTime -= reloadTime > 0 ? Time.deltaTime : 0;

        if (reloadTime <= 0 && Input.GetButton("Fire1"))
        {
            Instantiate(shotPrefab.gameObject, shotsOrigin.position, shotsOrigin.rotation);
            reloadTime = fireRate;
        }
	}
}
