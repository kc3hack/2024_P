using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncursionJudger : MonoBehaviour, IPassJudgement
{
    private Vector3 generatePosition;
    private Vector3 generateRotation;

    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        generatePosition = this.transform.position + (new Vector3(-119f, 14.3f, -278.2f) - new Vector3(-118.58f, 11.52f, -151.73f));
        return generatePosition;
    }

    Vector3 IPassJudgement.ReturnGenerateRotation()
    {        
        generateRotation = new Vector3(0f, 0f, 0f);
        return generateRotation;
    }
}
