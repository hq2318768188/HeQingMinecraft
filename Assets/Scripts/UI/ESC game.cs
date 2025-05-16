using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCgame : MonoBehaviour
{
    public void ExitGame()
    {
        // 如果在Unity编辑器中运行
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else //发布后退出
            Application.Quit();
#endif
    }
}
