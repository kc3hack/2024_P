using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbnNPC : MonoBehaviour
{
    public bool isAbnormal = true;
    public GameObject NormalNPC;
    public GameObject AbnormalNPC;

    void Start() { }

    void FixedUpdate()
    {
        if (isAbnormal)
        {
            NormalNPC.SetActive(false);
            AbnormalNPC.SetActive(true);
        }
        else
        {
            NormalNPC.SetActive(true);
            AbnormalNPC.SetActive(false);
        }
    }

}
