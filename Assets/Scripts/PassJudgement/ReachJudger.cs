using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachJudger : MonoBehaviour, IPassJudgement
{
    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        Debug.Log("ゴールに到達しました");
        return Vector3.zero;
    }
}
