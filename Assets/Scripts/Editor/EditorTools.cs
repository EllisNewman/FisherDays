﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class EditorTools {

	[MenuItem("Excel's Tools/Run _F5", false, 001)]
    public static void RunGame()
    {
        GeneralTools.instance.RunGame();
    }

    [MenuItem("Excel's Tools/Pause _F6", false, 002)]
    public static void PauseGame()
    {
        GeneralTools.instance.PauseGame();
    }

    [MenuItem("Excel's Tools/Load Scene/Main &1", false, 100)]
    public static void LoadMainScene()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Main.unity");
    }
    
    

}
