using UnityEngine;

public class NPCMovementController
{
    private Transform[] targetsTransform;
    private float moveSpeed = 5f;
    private int currentTargetIndex = 0;
    private bool isWalking = true;
    private Animator walkAnimator;

    public NPCMovementController(Transform[] targetsTransform, float moveSpeed, Animator walkAnimator)
    {
        this.targetsTransform = targetsTransform;
        this.moveSpeed = moveSpeed;
        this.walkAnimator = walkAnimator;
    }

    public void MoveNPC(Transform npcTransform)
    {
        if (isWalking)
        {
            npcTransform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Vector3.Distance(npcTransform.position, targetsTransform[currentTargetIndex].position) < 0.1f)
        {
            if (currentTargetIndex < targetsTransform.Length - 1)
            {
                isWalking = false;
                currentTargetIndex++;
                npcTransform.LookAt(targetsTransform[currentTargetIndex]);
                isWalking = true;
            }
            else
            {
                if(isWalking)
                {
                    walkAnimator.SetBool("isWalking", false);
                    isWalking = false;
                }
            }
        }
    }
}
