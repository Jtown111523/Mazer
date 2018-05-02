using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour {

    Animator animator;

    CharacterController characterController;

    PlayerController playerController;

    public float smoothness;

	// Use this for initialization
	void Awake () {

        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        playerController = GetComponent<PlayerController>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float speedPercent = characterController.velocity.magnitude / playerController.runspeed;

        animator.SetFloat("speedPercent", speedPercent, smoothness, Time.deltaTime);
		
	}
}
