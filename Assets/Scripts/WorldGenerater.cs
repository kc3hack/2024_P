using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerater : MonoBehaviour
{
    [SerializeField] GameObject[] worldPrefabs = new GameObject[5];

   public GameObject GenerateWorld(int elementNumber, Vector3 generatePosition)
   {
        Instantiate(worldPrefabs[elementNumber], generatePosition, Quaternion.identity);

        //異変生成のメソッド(worldPrefabs[elementNumnber]);
        return worldPrefabs[elementNumber];
   }
}
