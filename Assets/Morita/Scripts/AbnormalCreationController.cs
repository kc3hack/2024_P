using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbnormalCreationController : MonoBehaviour
{
    private int abnormalQuantity=10;//実装する異変の数を格納
    public int abnormalCreationRatio = 5;//異変を生成する割合
    private List<bool>abnormalList = new List<bool>();//異変を管理するリスト。異変のオブジェクト
    public AbnormalCreationController(/*引数は生成されたワールドのオブジェクトa*/){
        //abnormalList[0]= a.ihenA.Script.isAbnormal;
        //abnormalList[1]= a.ihenB.Script.isAbnormal;
        //abnormalList[2]= a.ihenC.Script.isAbnormal;
        //abnormalList[3]= a.ihenD.Script.isAbnormal;
    }

    private bool AbnormalSelect()//リストで管理している異変を生成するか、生成するならばどれを生成するか定める。返却値はゲームシステムにおけるプレイヤーの行動の正誤判定に用いる
    {
        int abnormalCreateRandNum = Random.Range(1,11);

        //異変を作るかどうか
        if(abnormalCreateRandNum < abnormalCreationRatio){
            //異変を生成する
            int abnormalRandomNum = Random.Range(0,abnormalQuantity);
            abnormalList[abnormalRandomNum] = true;
            bool isAbnormalCreated = true;
            return isAbnormalCreated;
        }else{
            //異変を作らない
            bool isAbnormalCreated = false;
            return isAbnormalCreated;
        }
    }
}
