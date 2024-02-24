using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbnPanel : MonoBehaviour
{
    public bool isAbnormal = true;
    public GameObject NormalPanel;
    public GameObject AbnormalPanel;

    void Start() { }

    void FixedUpdate()
    {
        if (isAbnormal)
        {
            NormalPanel.SetActive(false);
            AbnormalPanel.SetActive(true);
        }
        else
        {
            NormalPanel.SetActive(true);
            AbnormalPanel.SetActive(false);
        }
    }

}
