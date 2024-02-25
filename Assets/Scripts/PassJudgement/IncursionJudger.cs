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
        generatePosition = this.transform.position + (new Vector3(-205.7f, 18.3f, -205.9f) - new Vector3(-119.7781f, 18.20895f, -205.711f));
        return generatePosition;
    }

    Vector3 IPassJudgement.ReturnGenerateRotation()
    {        
        generateRotation = this.transform.rotation.eulerAngles - new Vector3(0f, 90f, 0f);
        return generateRotation;
    }
}
