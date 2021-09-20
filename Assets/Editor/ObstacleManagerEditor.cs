using UnityEngine;
using UnityEditor;
//[ExecuteAlways]
[CustomEditor(typeof(ObstacleManager))]
public class ObstacleManagerEditor : Editor
{
    public static ObstacleManager obstacleManager;
    static int columns = 10;
    static int rows = 10;
    public override void OnInspectorGUI()
    {
        
        base.OnInspectorGUI();
        obstacleManager = (ObstacleManager)target;

        for (int i = columns - 1 ; i>=0 ; i--)
        {
            GUILayout.BeginHorizontal();
            for (int j = 0 ; j <rows ; j++)
            {
                if (GUILayout.Button(j.ToString() + "," + i.ToString()))
                {
                    obstacleManager.ObstacleFunctionality(j, i);
                }
            }
            GUILayout.EndHorizontal();
        }
        if (GUILayout.Button("Clear Obstacles"))
        {
            obstacleManager.ClearAllObstacles();
        }
    }

    

}    
