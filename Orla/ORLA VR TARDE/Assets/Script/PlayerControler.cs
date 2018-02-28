using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    CharacterController playerControler;
    public float Speed;

    private void Awake()
    {
        playerControler = GetComponent<CharacterController>();
    }
 /*   void Start () {

	}
*/	
	// Update is called once per frame
	void Update () {
        moveTo();
        
	}
    void moveTo()
    {
        float horizont = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");


        Vector3 movimento = transform.right * horizont * Speed;
        Vector3 movimento2 = transform.forward * vertic * Speed;

        playerControler.SimpleMove(movimento);
        playerControler.SimpleMove(movimento2);
    }
}
