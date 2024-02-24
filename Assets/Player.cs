using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject hitObject;
    public bool hasIncursion,hasPassed,hasBack,hasReached;
    public Vector3 stairGeneratePosition, mainAndCornerGeneratePosition, GeneratePosition;
    public Vector3 stairGenerateRotation, mainAndCornerGenerateRotation, GenerateRotation;
    
    void Update()
    {
        Ray ray = new Ray(this.transform.position + new Vector3(0, 1.1f, 0), Vector3.up);
        //Debug.DrawRay (ray.origin, ray.direction * 100, Color.red, 3.0f);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if(hitObject.CompareTag("Incursion"))
            {
                //Debug.Log("侵入");
                hasIncursion = hitObject.GetComponent<IPassJudgement>().JudgePass();
                mainAndCornerGeneratePosition = hitObject.GetComponent<IPassJudgement>().ReturnGeneratePosition();
                mainAndCornerGenerateRotation = hitObject.GetComponent<IPassJudgement>().ReturnGenerateRotation();
                hitObject.SetActive(false);
            }
            else if(hitObject.CompareTag("Pass"))
            {
                //Debug.Log("通過");
                hasPassed = hitObject.GetComponent<IPassJudgement>().JudgePass();
                stairGeneratePosition = hitObject.GetComponent<IPassJudgement>().ReturnGeneratePosition();
                stairGenerateRotation = hitObject.GetComponent<IPassJudgement>().ReturnGenerateRotation();
                hitObject.SetActive(false);
            }
            else if(hitObject.CompareTag("Back"))
            {
                //Debug.Log("引き返し");
                hasBack = hitObject.GetComponent<IPassJudgement>().JudgePass();
            }
            else if(hitObject.CompareTag("Reach"))
            {
                //Debug.Log("ゴール");
                hasReached = hitObject.GetComponent<IPassJudgement>().JudgePass();
            }
        }
    }
}
