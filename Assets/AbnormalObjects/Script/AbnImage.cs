using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbnImage : MonoBehaviour
{
    /*
        [[How to use]]
        1. 画像をプロジェクトファイルに読み込む（PNG形式が良い）
        2. 画像をInspectorで開き、Texture Typeを"Sprite (2D and UI)"に設定する
        3. このPrefabをワールド内に配置する
        4. 配置したPrefabの子オブジェクトにそれぞれ画像を設定し、調整する
    */

    public bool isAbnormal = true;
    public GameObject NormalPoster;
    public GameObject AbnormalPoster;

    void Start() { }

    void FixedUpdate()
    {
        if (isAbnormal)
        {
            NormalPoster.SetActive(false);
            AbnormalPoster.SetActive(true);
        }
        else
        {
            NormalPoster.SetActive(true);
            AbnormalPoster.SetActive(false);
        }
    }

}
