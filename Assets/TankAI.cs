using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAI : MonoBehaviour {

    public float chaseDistance = 20f;
    public float attackDistance = 10f;
    public GameObject player;
    public GameObject bullet;
    public Transform torrent;
    Animator animator;

    public GameObject GetPlayer() {
        return player;
    }

    void Fire() {
        var b = Instantiate(bullet, torrent.position, torrent.rotation);
        b.GetComponent<Rigidbody>().AddForce(torrent.forward * 500f);
    }

    public void StartFiring() {
        InvokeRepeating("Fire", 0.5f, 0.5f);
    }

    public void StopFiring() {
        CancelInvoke("Fire");
    }

    // Use this for initialization
    void Start() {
        animator = gameObject.GetComponent<Animator>();
        
        Debug.Log(animator);
    }


    // Update is called once per frame
    void Update() {
        var distance = Vector3.Distance(player.transform.position, transform.position);

        animator.SetBool("inChaseRange", distance <= chaseDistance);
        animator.SetBool("inAttackRange", distance <= attackDistance);
    }
}