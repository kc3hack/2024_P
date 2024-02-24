using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //生成したワールドを格納する配列
    private List<GameObject> generatedWorldList = new List<GameObject>();
    
    [SerializeField] private GameObject[] initialWorlds = new GameObject[3];

    [SerializeField] private GameObject playerObj;
    private Player player;

    [SerializeField] private GameObject worldGeneraterObj;
    private WorldGenerater worldGenerater;
    
    private void Awake()
    {
        player = playerObj.GetComponent<Player>();
        worldGenerater = worldGeneraterObj.GetComponent<WorldGenerater>();
    }

    private void Start()
    {
        for (int i = 0; i < 3 ; i++)
        {
            worldGenerater.GenerateInitialWorld(initialWorlds[i]);
            generatedWorldList.Add(initialWorlds[i]);
        }
    }

    private void Update() 
    {
        if(player.hasIncursion)
        {
            generatedWorldList.Add(worldGenerater.GenerateWorld(1, player.mainAndCornerGeneratePosition, player.mainAndCornerGenerateRotation));
            player.hasIncursion = false;
        }
        if(player.hasPassed)
        {
            generatedWorldList.Add(worldGenerater.GenerateWorld(0, player.stairGeneratePosition, player.stairGenerateRotation));
            player.hasPassed = false;
        }
        if(player.hasBack)
        {
            
        }
        if(player.hasReached)
        {
            
        }
    }
}
