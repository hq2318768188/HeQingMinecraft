using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCgame : MonoBehaviour
{
    public void ExitGame()
    {
        // �����Unity�༭��������
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else //�������˳�
            Application.Quit();
#endif
    }
}
