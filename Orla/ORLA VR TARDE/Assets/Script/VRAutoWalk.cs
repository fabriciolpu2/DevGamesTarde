using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class VRAutoWalk : MonoBehaviour
{
    public float speed = 3.0F;
    public bool moveForward;
    private CharacterController controller;
    private Transform vrHead;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        vrHead = Camera.main.transform;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            moveForward = !moveForward;
        }

        if (moveForward)
        {
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }
    }
}