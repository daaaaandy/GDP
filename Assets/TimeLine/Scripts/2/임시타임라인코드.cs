using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class 임시타임라인코드 : MonoBehaviour

{
    public GameObject test1;
    public GameObject test2;

    void OnEnable()
    {
        if (test2 == null)
            test2 = GameObject.Find("Dialogue (2)");
        if(test1 == null)
            test1 = GameObject.Find("Dialogue (1)");
    

        if(SystemMessage.instance.YorN == true)
        {
            test1.SetActive(true);
            if(test1.activeSelf)
        {
            TimeLineManager.instance.isDialog = true;
        }
        }
        else if(SystemMessage.instance.YorN == false)
        {
            test2.SetActive(true);   
            if(test2.activeSelf)
        {
            TimeLineManager.instance.isDialog = true;
        }
        }
    }
}

