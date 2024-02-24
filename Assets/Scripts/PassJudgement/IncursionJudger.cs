using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncursionJudger : MonoBehaviour, IPassJudgement
{
    private Vector3 generatePosition;

    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        generatePosition = this.transform.position + (new Vector3(-118.3f, 7.63f, -159.51f) - this.transform.position);
        return generatePosition;
    }
}
