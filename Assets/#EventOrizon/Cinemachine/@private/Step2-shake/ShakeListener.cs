using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

//https://www.youtube.com/watch?v=8XZqopmI6AI

public class ShakeListener : MonoBehaviour {
    [SerializeField] private CinemachineImpulseSource cineSource;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private bool autoShake;

    void Awake () {
        cineSource = GetComponent<CinemachineImpulseSource> ();
    }

    void Start () {
        if (autoShake) {
            InvokeRepeating ("Shake", 3f, 4f);
        }
    }

    private void Shake () {
        cineSource.GenerateImpulse ();
        if (animator)
                animator.SetTrigger ("GetHit");
    }

    private void OnTriggerEnter (Collider other) {
        if (animator)
            animator.SetTrigger ("GetHit");

        Shake ();
    }

    public void DealDamage () {
        Debug.Log ("DealDamage");
    }

}