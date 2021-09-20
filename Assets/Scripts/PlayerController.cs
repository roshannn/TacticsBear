using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text boxPos;
    public MapBehaviour mapBehaviour;
    public float moveSpeed = 5;
    
    void Update()
    {
        GetCoordinatesOfMousePos();
        //GetDestination();
    }

    private void GetCoordinatesOfMousePos()
    {
        RaycastHit raycastHit;
        Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(raycast, out raycastHit, 100f) && raycastHit.collider.GetComponent<GridBlock>() != null)
        {
            //Debug.Log("Ray has hit", raycastHit.collider.gameObject);
            var block = raycastHit.collider.GetComponent<GridBlock>();
            
            boxPos.text = block.x.ToString() + "," + block.y.ToString();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log(block.x+ ","+ block.y);
                mapBehaviour.endX = block.x;
                mapBehaviour.endY = block.y;
                mapBehaviour.findDistance = true;
                
            }
        }
    }

    public void MovePlayer(List<GridBlock> path,int i)
    {
        var nextPos = new Vector3(path[i].transform.position.x, 1, path[i].transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position,nextPos, moveSpeed);
        
    }

    
}
