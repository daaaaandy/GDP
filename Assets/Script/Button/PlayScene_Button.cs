using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScene_Button : MonoBehaviour
{
    public void LoadPlayScene()
    {
        // "PlayScene"�̶�� �̸��� ���� �ε��մϴ�.
        SceneManager.LoadScene("Story");
    }
}