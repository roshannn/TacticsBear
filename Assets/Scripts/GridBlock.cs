using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GridBlock : MonoBehaviour
{
    public int x = 0;
    public int y = 0;
    public int visited;
    public bool obstaclePresent = false;
    public bool presenceDetected = false;

    public void ClearObstacle()
    {
        if (transform.childCount != 0)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
            obstaclePresent = false;
            return;
        }
        else
        {
            return;
        }
    }
    public void ObstacleFunctionality(GameObject obs)
    {
        if (!presenceDetected)
        {
            CreateObstacle(obs);
            ClearObstacle();
        }
        else
        {
            Debug.Log("Someoneis there cant create obstacle");
        }

    }

    private void CreateObstacle(GameObject obs)
    {
        
        if (transform.childCount == 0)
        {
            var obstacle = GameObject.Instantiate(obs, this.transform);
            var desiredPos = this.transform.position;
            desiredPos.y = 1;
            obstacle.transform.position = desiredPos;
            obstaclePresent = true;
        }
    }
}
