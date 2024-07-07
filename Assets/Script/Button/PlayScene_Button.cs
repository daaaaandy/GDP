using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScene_Button : MonoBehaviour
{
    public void LoadPlayScene()
    {
        // "PlayScene"이라는 이름의 씬을 로드합니다.
        SceneManager.LoadScene("Story");
    }
}