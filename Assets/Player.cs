using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject hitObject;
    private bool hasIncursion,hasPassed,hasBack,hasReached;
    public GameObject IncursionObject,PassObject,BackObject,ReachObject;
    
    void Update()
    {
        Ray ray = new Ray(transform.forward, Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if(hitObject ==IncursionObject)
            {
                hasIncursion = hitObject.GetComponent<IWorldBool>().GetWorldBool();
            }
            else if(hitObject ==PassObject)
            {
                hasPassed = hitObject.GetComponent<IWorldBool>().GetWorldBool();
            }
            else if(hitObject ==BackObject)
            {
                hasBack = hitObject.GetComponent<IWorldBool>().GetWorldBool();
            }
            else if(hitObject ==ReachObject)
            {
                hasReached = hitObject.GetComponent<IWorldBool>().GetWorldBool();
            }
        }
    }
}
