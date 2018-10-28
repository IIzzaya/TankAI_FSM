using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAIFSM : StateMachineBehaviour {

	[HideInInspector] public GameObject NPC;
	[HideInInspector] public GameObject target;
	public float moveSpeed = 2.0f;
	public float rotateSpeed = 1.0f;
	public float accuracy = 3.0f;

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		NPC = animator.gameObject;
		target = NPC.GetComponent<TankAI>().GetPlayer();
	}

}