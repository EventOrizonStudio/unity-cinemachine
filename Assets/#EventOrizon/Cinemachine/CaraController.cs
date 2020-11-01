using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaraController : MonoBehaviour {
    [SerializeField]
    private float speed = 10; //vitesse de déplacement

    [SerializeField]
    private Vector3 rotVector = new Vector3 (0, 20, 0); //vitesse de rotation

    [SerializeField]
    private Animator animator;

    void Update () {
        if (Input.GetMouseButtonDown (2)) {
            Debug.Log ("Pressed center click: attack");
            animator.SetTrigger ("GetHit");
        }
        if (Input.GetMouseButtonDown (1)) {
            Debug.Log ("Pressed right click: attack");
            animator.SetTrigger ("Attack");
        }
    }

    void FixedUpdate () {

        float rot = Input.GetAxis ("Horizontal"); // rot
        float move = Input.GetAxis ("Vertical"); //move
        //animator.SetFloat ("move", move);

        animator.SetBool ("IsMoving", move != 0f ? true:false);
        GetComponent<Rigidbody> ().velocity = transform.forward * move * speed;
        this.transform.Rotate (rotVector * rot);
    }

    public void DealDamage(){
        Debug.Log ("DealDamage");
    }

    public void FireProjectile(){
        Debug.Log ("FireProjectile");
    }
}