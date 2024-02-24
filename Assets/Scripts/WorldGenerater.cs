using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerater : MonoBehaviour
{
    [SerializeField] GameObject[] worldPrefabs = new GameObject[5];

   public void GenerateInitialWorld(GameObject world)
   {
        Instantiate(world);

        //異変生成メソッド
   }

   public GameObject GenerateWorld(int elementNumber, Vector3 generatePosition, Vector3 generateRotation)
   {
        Instantiate(worldPrefabs[elementNumber], generatePosition, Quaternion.Euler(generateRotation));

        //異変生成のメソッド(worldPrefabs[elementNumnber]);
        return worldPrefabs[elementNumber];
   }
}
