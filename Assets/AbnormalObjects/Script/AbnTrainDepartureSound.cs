using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbnTrainDepartureSound : MonoBehaviour
{
    public bool isAbnormal = true;
    public AudioSource NormalSound;
    public AudioSource AbnormalSound;

    void Start() { }

    void FixedUpdate()
    {
        // ドップラー効果が酷いときは、Audio SourceのSpatial Blendの値を小さくする。
        if (isAbnormal)
        {
            if (!AbnormalSound.isPlaying)
            {
                AbnormalSound.Play();
            }
        }
        else
        {
            if (!NormalSound.isPlaying)
            {
                NormalSound.Play();
            }
        }
    }
}

