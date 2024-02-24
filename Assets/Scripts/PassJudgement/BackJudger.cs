using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackJudger : MonoBehaviour, IPassJudgement
{
    private Vector3 generatePosition;
    private Vector3 generateRotation;

    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        //generatePosition = this.transform.position + new Vector3(判定オブジェクトと生成ポジションの差);
        return generatePosition;
    }

    Vector3 IPassJudgement.ReturnGenerateRotation()
    {        
        //generateRotation = new Vector3(-90f, -90f, 90f);
        return generateRotation;
    }
}
