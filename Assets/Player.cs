using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject hitObject;
    
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            hitObject = hit.collider.gameObject;
            bool WorldBool = hitObject.GetComponent<IWorldBool>().GetWorldBool();
        }
    }
}
