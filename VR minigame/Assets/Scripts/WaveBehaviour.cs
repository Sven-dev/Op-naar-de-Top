using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBehaviour : StateMachineBehaviour
{
    [SerializeField]
    private string booleanVariableName;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(booleanVariableName, true);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(booleanVariableName, false);
    }
}