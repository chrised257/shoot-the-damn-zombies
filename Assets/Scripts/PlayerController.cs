using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 3.0f;
    public float rotationSpeed = 5.0f;

    private CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        Vector3 forward = transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical");
        characterController.SimpleMove(forward);
	}
}
