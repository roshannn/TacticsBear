using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObstacleManager : MonoBehaviour
{
    
    public MapBehaviour mapBehaviour;
    public Obstacle obstacleSO;
    public GameObject[,] gridArray;
    public void Awake()
    {
        gridArray = mapBehaviour.gridArray;
    }
    public void ObstacleFunctionality(GridBlock gridBlock)
    {
        gridBlock.ObstacleFunctionality(obstacleSO.obstacle);
    }

    public void ClearAllObstacles()
    {
        for(int i = 0; i < mapBehaviour.columns; i++)
        {
            for(int j = 0;j< mapBehaviour.rows; j++)
            {
                gridArray[i, j].GetComponent<GridBlock>().ClearObstacle();
            }
        }
    }
    
}