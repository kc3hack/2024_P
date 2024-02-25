using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassJudger : MonoBehaviour, IPassJudgement
{
    private Vector3 generatePosition;
    private Vector3 generateRotation;

    bool IPassJudgement.JudgePass()
    {
        return true;
    }

    Vector3 IPassJudgement.ReturnGeneratePosition()
    {
        generatePosition = this.transform.position + (new Vector3(-122.8f, 12.85f, -202.22f) - new Vector3(-110.25f, 11.61f, -126.52f));
        return generatePosition;
    }

    Vector3 IPassJudgement.ReturnGenerateRotation()
    {        
        generateRotation = this.transform.rotation.eulerAngles - new Vector3(0f, 90f, 0f);
        return generateRotation;
    }
}
