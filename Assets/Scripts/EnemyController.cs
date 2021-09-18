using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public MapBehaviour mapBehaviour;
    public float moveSpeed;
    public void MoveEnemy(List<GameObject> path, int i)
    {
        var nextPos = new Vector3(path[i].transform.position.x, 1, path[i].transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, nextPos, moveSpeed);

    }
}