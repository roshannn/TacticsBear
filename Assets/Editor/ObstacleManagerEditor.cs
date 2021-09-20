using UnityEngine;
using UnityEditor;
//[ExecuteAlways]
[CustomEditor(typeof(ObstacleManager))]
public class ObstacleManagerEditor : Editor
{
    public static ObstacleManager obstacleManager;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        obstacleManager = (ObstacleManager)target;
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,9"))
            obstacleManager.ObstacleFunctionality(0, 9);
        if (GUILayout.Button("1,9"))
            obstacleManager.ObstacleFunctionality(1, 9);
        if (GUILayout.Button("2,9"))
            obstacleManager.ObstacleFunctionality(2, 9);
        if (GUILayout.Button("3,9"))
            obstacleManager.ObstacleFunctionality(3, 9);
        if (GUILayout.Button("4,9"))
            obstacleManager.ObstacleFunctionality(4, 9);
        if (GUILayout.Button("5,9"))
            obstacleManager.ObstacleFunctionality(5, 9);
        if (GUILayout.Button("6,9"))
            obstacleManager.ObstacleFunctionality(6, 9);
        if (GUILayout.Button("7,9"))
            obstacleManager.ObstacleFunctionality(7, 9);
        if (GUILayout.Button("8,9"))
            obstacleManager.ObstacleFunctionality(8, 9);
        if (GUILayout.Button("9,9"))
            obstacleManager.ObstacleFunctionality(9, 9);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,8"))
            obstacleManager.ObstacleFunctionality(0, 8);
        if (GUILayout.Button("1,8"))
            obstacleManager.ObstacleFunctionality(1, 8);
        if (GUILayout.Button("2,8"))
            obstacleManager.ObstacleFunctionality(2, 8);
        if (GUILayout.Button("3,8"))
            obstacleManager.ObstacleFunctionality(3, 8);
        if (GUILayout.Button("4,8"))
            obstacleManager.ObstacleFunctionality(4, 8);
        if (GUILayout.Button("5,8"))
            obstacleManager.ObstacleFunctionality(5, 8);
        if (GUILayout.Button("6,8"))
            obstacleManager.ObstacleFunctionality(6, 8);
        if (GUILayout.Button("7,8"))
            obstacleManager.ObstacleFunctionality(7, 8);
        if (GUILayout.Button("8,8"))
            obstacleManager.ObstacleFunctionality(8, 8);
        if (GUILayout.Button("9,8"))
            obstacleManager.ObstacleFunctionality(9, 8);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,7"))
            obstacleManager.ObstacleFunctionality(0, 7);
        if (GUILayout.Button("1,7"))
            obstacleManager.ObstacleFunctionality(1, 7);
        if (GUILayout.Button("2,7"))
            obstacleManager.ObstacleFunctionality(2, 7);
        if (GUILayout.Button("3,7"))
            obstacleManager.ObstacleFunctionality(3, 7);
        if (GUILayout.Button("4,7"))
            obstacleManager.ObstacleFunctionality(4, 7);
        if (GUILayout.Button("5,7"))
            obstacleManager.ObstacleFunctionality(5, 7);
        if (GUILayout.Button("6,7"))
            obstacleManager.ObstacleFunctionality(6, 7);
        if (GUILayout.Button("7,7"))
            obstacleManager.ObstacleFunctionality(7, 7);
        if (GUILayout.Button("8,7"))
            obstacleManager.ObstacleFunctionality(8, 7);
        if (GUILayout.Button("9,7"))
            obstacleManager.ObstacleFunctionality(9, 7);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,6"))
            obstacleManager.ObstacleFunctionality(0, 6);
        if (GUILayout.Button("1,6"))
            obstacleManager.ObstacleFunctionality(1, 6);
        if (GUILayout.Button("2,6"))
            obstacleManager.ObstacleFunctionality(2, 6);
        if (GUILayout.Button("3,6"))
            obstacleManager.ObstacleFunctionality(3, 6);
        if (GUILayout.Button("4,6"))
            obstacleManager.ObstacleFunctionality(4, 6);
        if (GUILayout.Button("5,6"))
            obstacleManager.ObstacleFunctionality(5, 6);
        if (GUILayout.Button("6,6"))
            obstacleManager.ObstacleFunctionality(6, 6);
        if (GUILayout.Button("7,6"))
            obstacleManager.ObstacleFunctionality(7, 6);
        if (GUILayout.Button("8,6"))
            obstacleManager.ObstacleFunctionality(8, 6);
        if (GUILayout.Button("9,6"))
            obstacleManager.ObstacleFunctionality(9, 6);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,5"))
            obstacleManager.ObstacleFunctionality(0, 5);
        if (GUILayout.Button("1,5"))
            obstacleManager.ObstacleFunctionality(1, 5);
        if (GUILayout.Button("2,5"))
            obstacleManager.ObstacleFunctionality(2, 5);
        if (GUILayout.Button("3,5"))
            obstacleManager.ObstacleFunctionality(3, 5);
        if (GUILayout.Button("4,5"))
            obstacleManager.ObstacleFunctionality(4, 5);
        if (GUILayout.Button("5,5"))
            obstacleManager.ObstacleFunctionality(5, 5);
        if (GUILayout.Button("6,5"))
            obstacleManager.ObstacleFunctionality(6, 5);
        if (GUILayout.Button("7,5"))
            obstacleManager.ObstacleFunctionality(7, 5);
        if (GUILayout.Button("8,5"))
            obstacleManager.ObstacleFunctionality(8, 5);
        if (GUILayout.Button("9,5"))
            obstacleManager.ObstacleFunctionality(9, 5);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,4"))
            obstacleManager.ObstacleFunctionality(0, 4);
        if (GUILayout.Button("1,4"))
            obstacleManager.ObstacleFunctionality(1, 4);
        if (GUILayout.Button("2,4"))
            obstacleManager.ObstacleFunctionality(2, 4);
        if (GUILayout.Button("3,4"))
            obstacleManager.ObstacleFunctionality(3, 4);
        if (GUILayout.Button("4,4"))
            obstacleManager.ObstacleFunctionality(4, 4);
        if (GUILayout.Button("5,4"))
            obstacleManager.ObstacleFunctionality(5, 4);
        if (GUILayout.Button("6,4"))
            obstacleManager.ObstacleFunctionality(6, 4);
        if (GUILayout.Button("7,4"))
            obstacleManager.ObstacleFunctionality(7, 4);
        if (GUILayout.Button("8,4"))
            obstacleManager.ObstacleFunctionality(8, 4);
        if (GUILayout.Button("9,4"))
            obstacleManager.ObstacleFunctionality(9, 4);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,3"))
            obstacleManager.ObstacleFunctionality(0, 3);
        if (GUILayout.Button("1,3"))
            obstacleManager.ObstacleFunctionality(1, 3);
        if (GUILayout.Button("2,3"))
            obstacleManager.ObstacleFunctionality(2, 3);
        if (GUILayout.Button("3,3"))
            obstacleManager.ObstacleFunctionality(3, 3);
        if (GUILayout.Button("4,3"))
            obstacleManager.ObstacleFunctionality(4, 3);
        if (GUILayout.Button("5,3"))
            obstacleManager.ObstacleFunctionality(5, 3);
        if (GUILayout.Button("6,3"))
            obstacleManager.ObstacleFunctionality(6, 3);
        if (GUILayout.Button("7,3"))
            obstacleManager.ObstacleFunctionality(7, 3);
        if (GUILayout.Button("8,3"))
            obstacleManager.ObstacleFunctionality(8, 3);
        if (GUILayout.Button("9,3"))
            obstacleManager.ObstacleFunctionality(9, 3);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,2"))
            obstacleManager.ObstacleFunctionality(0, 2);
        if (GUILayout.Button("1,2"))
            obstacleManager.ObstacleFunctionality(1, 2);
        if (GUILayout.Button("2,2"))
            obstacleManager.ObstacleFunctionality(2, 2);
        if (GUILayout.Button("3,2"))
            obstacleManager.ObstacleFunctionality(3, 2);
        if (GUILayout.Button("4,2"))
            obstacleManager.ObstacleFunctionality(4, 2);
        if (GUILayout.Button("5,2"))
            obstacleManager.ObstacleFunctionality(5, 2);
        if (GUILayout.Button("6,2"))
            obstacleManager.ObstacleFunctionality(6, 2);
        if (GUILayout.Button("7,2"))
            obstacleManager.ObstacleFunctionality(7, 2);
        if (GUILayout.Button("8,2"))
            obstacleManager.ObstacleFunctionality(8, 2);
        if (GUILayout.Button("9,2"))
            obstacleManager.ObstacleFunctionality(9, 2);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,1"))
            obstacleManager.ObstacleFunctionality(0, 1);
        if (GUILayout.Button("1,1"))
            obstacleManager.ObstacleFunctionality(1, 1);
        if (GUILayout.Button("2,1"))
            obstacleManager.ObstacleFunctionality(2, 1);
        if (GUILayout.Button("3,1"))
            obstacleManager.ObstacleFunctionality(3, 1);
        if (GUILayout.Button("4,1"))
            obstacleManager.ObstacleFunctionality(4, 1);
        if (GUILayout.Button("5,1"))
            obstacleManager.ObstacleFunctionality(5, 1);
        if (GUILayout.Button("6,1"))
            obstacleManager.ObstacleFunctionality(6, 1);
        if (GUILayout.Button("7,1"))
            obstacleManager.ObstacleFunctionality(7, 1);
        if (GUILayout.Button("8,1"))
            obstacleManager.ObstacleFunctionality(8, 1);
        if (GUILayout.Button("9,1"))
            obstacleManager.ObstacleFunctionality(9, 1);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0,0"))
            obstacleManager.ObstacleFunctionality(0, 0);
        if (GUILayout.Button("1,0"))
            obstacleManager.ObstacleFunctionality(1, 0);
        if (GUILayout.Button("2,0"))
            obstacleManager.ObstacleFunctionality(2, 0);
        if (GUILayout.Button("3,0"))
            obstacleManager.ObstacleFunctionality(3, 0);
        if (GUILayout.Button("4,0"))
            obstacleManager.ObstacleFunctionality(4, 0);
        if (GUILayout.Button("5,0"))
            obstacleManager.ObstacleFunctionality(5, 0);
        if (GUILayout.Button("6,0"))
            obstacleManager.ObstacleFunctionality(6, 0);
        if (GUILayout.Button("7,0"))
            obstacleManager.ObstacleFunctionality(7, 0);
        if (GUILayout.Button("8,0"))
            obstacleManager.ObstacleFunctionality(8, 0);
        if (GUILayout.Button("9,0"))
            obstacleManager.ObstacleFunctionality(9, 0);

        GUILayout.EndHorizontal();
        if(GUILayout.Button("Clear Obstacles"))
        {
            obstacleManager.ClearAllObstacles();
        }
    }

    

}    
