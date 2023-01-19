using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungryState : StateMachineBehaviour {

    GameObject Pet;
    //Vector3 foodbowl;
    //float speed;
    

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Pet = animator.gameObject;
        //foodbowl = new Vector3(8.0f, 0f, 0f);
        //speed = 2.0f;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Pet.transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime);
        //Pet.transform.rotation = Quaternion.LookRotation(foodbowl);
        //Pet.transform.Translate(0, 0, speed * Time.deltaTime);
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }


}
