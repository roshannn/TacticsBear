using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObstacleManager : MonoBehaviour
{
    public MapBehaviour mapBehaviour;
    public Obstacle obstacleSO;
    public void Awake()
    {

    }
    public void ObstacleFunctionality(int i, int j)

    {
        if (mapBehaviour.gridArray[i, j] != null)
        {
            mapBehaviour.gridArray[i, j].ObstacleFunctionality(obstacleSO.obstacle);
        }
        
    }

    public void ClearAllObstacles()
    {
        for(int i = 0; i < mapBehaviour.columns; i++)
        {
            for(int j = 0;j< mapBehaviour.rows; j++)
            {
                mapBehaviour.gridArray[i, j].ClearObstacle();
            }
        }
    }
    
}