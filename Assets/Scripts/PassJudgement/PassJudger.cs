using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassJudger : MonoBehaviour, IPassJudgement
{
    private Vector3 generatePosition;

    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        //generatePosition = this.transform.position + new Vector3(判定オブジェクトと生成ポジションの差);
        return generatePosition;
    }
}
