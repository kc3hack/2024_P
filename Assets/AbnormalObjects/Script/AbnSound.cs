using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbnSound : MonoBehaviour
{
    /*
        [[How to use]]
        1. オーディオファイルをプロジェクトファイルに読み込む（WAV形式かMP3形式が良い）
        2. このPrefabをワールド内に配置する
        3. 配置したPrefabの子オブジェクトにそれぞれ音声をアタッチし、音量を調整する
    */

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

