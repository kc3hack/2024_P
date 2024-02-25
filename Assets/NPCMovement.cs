using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform[] targetsTransform;
    public float moveSpeed = 5f;
    private Animator walkAnimator;

    private NPCMovementController movementController;

    private void Start()
    {
        walkAnimator = GetComponent <Animator> ();
        movementController = new NPCMovementController(targetsTransform, moveSpeed,walkAnimator);
    }

    void Update()
    {
        movementController.MoveNPC(transform);
    }
}
