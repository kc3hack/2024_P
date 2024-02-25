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
    [SerializeField] private GameObject GamaManeger;
    private Player player;

    [SerializeField] private GameObject worldGeneraterObj;
    private WorldGenerater worldGenerater;
    private AbnormalCreationController abnormalCreationController;

    private int consecutiveNumberOfCorrectAnswers = 0;
    
    private void Awake()
    {
        player = playerObj.GetComponent<Player>();
        worldGenerater = worldGeneraterObj.GetComponent<WorldGenerater>();
        abnormalCreationController = GamaManeger.GetComponent<AbnormalCreationController>();
    }

    private void Start()
    {
        worldGenerater.GenerateInitialWorld(initialWorlds[0]);
        generatedWorldList.Add(initialWorlds[0]);
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
            GameObject erasedObject = generatedWorldList[0];
            generatedWorldList.RemoveAt(0);
            Destroy(erasedObject);

            GameObject gameObject = worldGenerater.GenerateWorld(1, player.mainAndCornerGeneratePosition, player.mainAndCornerGenerateRotation);
            generatedWorldList.Add(gameObject);
            abnormalCreationController = new AbnormalCreationController(gameObject);
            abnormalCreationController.AbnormalSelect();
            player.hasIncursion = false;
        }
        if(player.hasPassed)
        {
            GameObject erasedObject = generatedWorldList[0];
            generatedWorldList.RemoveAt(0);
            Destroy(erasedObject);

            generatedWorldList.Add(worldGenerater.GenerateWorld(0, player.stairGeneratePosition, player.stairGenerateRotation));
            player.hasPassed = false;
        }
        if(player.hasBack)
        {
            GameObject erasedObject = generatedWorldList[0];
            generatedWorldList.RemoveAt(0);
            Destroy(erasedObject);

            generatedWorldList.Add(worldGenerater.GenerateWorld(6,player.stairGeneratePosition,player.stairGenerateRotation));        
            player.hasBack = false;
        }
        if(player.hasReached)
        {
            generatedWorldList.Add(worldGenerater.GenerateWorld(4,player.goalGeneratePosition,player.goalGenerateRotation));
            player.hasReached = false;
        }
    }
    private void EraseWorld(GameObject world)
    {

        Destroy(world);
    }
}
