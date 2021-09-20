using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class MapBehaviour : MonoBehaviour
{
    //pass to playerPrefab
    public Text boxPos;

    //prefabs
    public PlayerController player;
    public GridBlock gridBlock;
    public EnemyController enemy;

    //find path
    public bool findDistance = false;
    public bool findEnemyDistance = false;
    //make player move
    public Button Move;

    //checkPlayerReachedEnd
    //private bool destinationReached = false;

    //gridDimensions
    public int rows = 10;
    public int columns = 10;
    public int scale = 1;
    
    //Grid first block pos
    public Vector3 leftBottomLocation = new Vector3(0, 0, 0);
    public GridBlock[,] gridArray;

    //Path to follow
    public List<GridBlock> path = new List<GridBlock>();
    public List<GridBlock> enemyPath = new List<GridBlock>();
    //Start Location
    public int playerX = 0;
    public int playerY = 0;

    //End Location can be set
    public int endX = 2;
    public int endY = 2;

    public int enemyX = 9;
    public int enemyY = 9;

    private void Awake()
    {
        GridInitialization();
        PlayerInitialization();
        EnemyInitialization();
    }
    private void Start()
    {
        Move.onClick.AddListener(Movement);
    }
    private void Update()
    {
        if (findDistance)
        {
            InitialSetup();
            SetDistance();
            SetPath();
            findDistance = false;
        }
        if (findEnemyDistance)
        {
            InitialSetupEnemy();
            SetEnemyDistance();
            SetEnemyPath();
            findEnemyDistance = false;
        }
    }

    private void GridInitialization()
    {
        gridArray = new GridBlock[columns, rows];
        if (gridBlock)
        {
            GenerateGrid();
        }
        else
        {
            Debug.Log("GridBlockPrefabMissing");
        }
    }
    void GenerateGrid()
    {
        int num = 0;
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GridBlock obj = Instantiate<GridBlock>(gridBlock, new Vector3((leftBottomLocation.x + scale) * i, leftBottomLocation.y, (leftBottomLocation.z + scale) * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.x = i;
                obj.y = j;
                obj.gameObject.name = "GridBlock" + num.ToString();
                num++;
                gridArray[i, j] = obj;

            }
        }
    }

    private void PlayerInitialization()
    {
        player = GameObject.Instantiate<PlayerController>(player, new Vector3(gridArray[playerX, playerY].transform.position.x, gridArray[playerX, playerY].transform.position.y + 1, gridArray[playerX, playerY].transform.position.z), Quaternion.identity);
        player.mapBehaviour = this;
        player.boxPos = boxPos;
        gridArray[playerX, playerY].presenceDetected = true;
        //player.transform.SetParent(this.gameObject.transform);
    }
    private void EnemyInitialization()
    {
        enemy = GameObject.Instantiate<EnemyController>(enemy, new Vector3(gridArray[enemyX, enemyY].transform.position.x, gridArray[enemyX, enemyY].transform.position.y + 1, gridArray[enemyX, enemyY].transform.position.z), Quaternion.identity);
        enemy.mapBehaviour = this;
    }

    public void Movement() {
        Debug.Log("Click");
        StartCoroutine(MovePlayer());
    }
    public IEnumerator MovePlayer()
    {
        int i = path.Count - 2;
        while (i >= 0)
        {
            Debug.Log(i);
            player.MovePlayer(path, i);
            i--;
            yield return new WaitForSeconds(1);
        }
        yield return null;
        gridArray[playerX, playerY].presenceDetected = false;
        playerX = path[0].x;
        playerY = path[0].y;
        gridArray[playerX, playerY].presenceDetected = true;
        Debug.Log("end of coroutine");
        findEnemyDistance = true;
        yield return null;
        StartCoroutine(MoveEnemy());
    }
    public IEnumerator MoveEnemy()
    {
        int i = enemyPath.Count - 2;
        while (i >= 1)
        {
            enemy.MoveEnemy(enemyPath, i);
            i--;
            yield return new WaitForSeconds(1);
        }
        yield return null;
        gridArray[enemyX, enemyY].presenceDetected = false;
        enemyX = enemyPath[1].x;
        enemyY = enemyPath[1].y;
        yield return null;

    }
    private void InitialSetup()
    {
        foreach (GridBlock obj in gridArray)
        {
            obj.visited = -1;
        }
        gridArray[playerX, playerY].visited = 0;
        gridArray[enemyX, enemyY].visited = -1;
        //gridArray[enemyX, enemyY].playerReached = true;
    }
    private void InitialSetupEnemy()
    {
        foreach (GridBlock obj in gridArray)
        {
            obj.visited = -1;
        }
        gridArray[enemyX, enemyY].visited = 0;
        gridArray[enemyX, enemyY].presenceDetected = true;
    }

    void SetDistance()
    {
        int x = playerX;
        int y = playerY;
        int[] testArray = new int[rows * columns];
        for (int step = 1; step < rows * columns; step++)
        {
            foreach (GridBlock block in gridArray)
            {
                if (block.visited == step - 1)
                {
                    TestFourDirections(block.x, block.y, step);
                }
            }
        }

    }

    void SetPath()
    {
        int step;
        int x = endX;
        int y = endY;
        List<GridBlock> tempList = new List<GridBlock>();
        path.Clear();
        if (gridArray[endX, endY] && gridArray[endX, endY].visited > 0)
        {
            path.Add(gridArray[x, y]);
            step = gridArray[x, y].visited - 1;
        }
        else
        {
            Debug.Log("Cant Reach");
            return;
        }
        for (int i = step; step > -1; step--)
        {
            if (TestDirection(x, y, step, Direction.Up))
            {
                tempList.Add(gridArray[x, y + 1]);
            }
            if (TestDirection(x, y, step, Direction.Right))
            {
                tempList.Add(gridArray[x + 1, y]);
            }
            if (TestDirection(x, y, step, Direction.Down))
            {
                tempList.Add(gridArray[x, y - 1]);
            }
            if (TestDirection(x, y, step, Direction.Left))
            {
                tempList.Add(gridArray[x - 1, y]);
            }
            GridBlock tempObj = FindClosest(gridArray[endX, endY].transform, tempList);
            path.Add(tempObj);
            x = tempObj.x;
            y = tempObj.y;
            tempList.Clear();
            tempList = null;
        }
    }

    private void SetEnemyDistance()
    {
        int x = enemyX;
        int y = enemyY;
        int[] testArray = new int[rows * columns];
        for (int step = 1; step < rows * columns; step++)
        {
            foreach (GridBlock block in gridArray)
            {
                if (block.visited == step - 1)
                {
                    TestFourDirections(block.x, block.y, step);
                }
            }
        }
    }
    private void SetEnemyPath()
    {
        int step;
        int x = playerX;
        int y = playerY;
        List<GridBlock> tempList = new List<GridBlock>();
        enemyPath.Clear();
        if (gridArray[playerX, playerY] && gridArray[playerX, playerY].visited > 0)
        {
            enemyPath.Add(gridArray[x, y]);
            step = gridArray[x, y].visited - 1;
        }
        else
        {
            Debug.Log("Cant Reach");
            return;
        }
        for (int i = step; step > -1; step--)
        {
            if (TestDirection(x, y, step, Direction.Up))
            {
                tempList.Add(gridArray[x, y + 1]);
            }
            if (TestDirection(x, y, step, Direction.Right))
            {
                tempList.Add(gridArray[x + 1, y]);
            }
            if (TestDirection(x, y, step, Direction.Down))
            {
                tempList.Add(gridArray[x, y - 1]);
            }
            if (TestDirection(x, y, step, Direction.Left))
            {
                tempList.Add(gridArray[x - 1, y]);
            }
            GridBlock tempObj = FindClosest(gridArray[playerX, playerY].transform, tempList);
            enemyPath.Add(tempObj);
            x = tempObj.x;
            y = tempObj.y;
            tempList.Clear();
            tempList = null;
        }
    }

    bool TestDirection(int x, int y, int step, Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                if (y + 1 < rows && gridArray[x, y + 1] && gridArray[x, y + 1].visited == step && gridArray[x, y + 1].obstaclePresent ==false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Right:
                if (x + 1 < columns && gridArray[x + 1, y] && gridArray[x + 1, y].visited == step && !gridArray[x + 1, y].obstaclePresent)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Down:
                if (y - 1 > -1 && gridArray[x, y - 1] && gridArray[x, y - 1].visited == step && !gridArray[x, y - 1].obstaclePresent)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            case Direction.Left:
                if (x - 1 > -1 && gridArray[x - 1, y] && gridArray[x - 1, y].visited == step && !gridArray[x - 1, y].obstaclePresent)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        return false;
    }
    private void TestFourDirections(int x, int y, int step)
    {
        if (TestDirection(x, y, -1, Direction.Up)){
            SetVisited(x, y + 1, step);
        }
        if (TestDirection(x, y, -1, Direction.Right))
        {
            SetVisited(x + 1, y, step);
        }
        if (TestDirection(x, y, -1, Direction.Down))
        {
            SetVisited(x, y - 1, step);
        }
        if (TestDirection(x, y, -1, Direction.Left))
        {
            SetVisited(x - 1, y, step);
        }

    }
    void SetVisited(int x, int y, int step)
    {
        if (gridArray[x, y])
        {
            gridArray[x, y].visited = step; 
        }
    }

    GridBlock FindClosest(Transform targetLoc,List<GridBlock> list)
    {
        float currentDistance = scale * rows * columns;
        int indexNumber = 0;
        for(int i = 0; i < list.Count; i++)
        {
            if (Vector3.Distance(targetLoc.position, list[i].transform.position) < currentDistance)
            {
                currentDistance = Vector3.Distance(targetLoc.position, list[i].transform.position);
                indexNumber = i;
            }
            
        }
        return list[indexNumber];
    }
}