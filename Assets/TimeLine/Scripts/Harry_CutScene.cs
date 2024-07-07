using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harry_CutScene : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        if(anim == null)
            Debug.Log("애니미 널");
        else
            Debug.Log("애니미 있음");
    }

    public void Harry_Start_Anim()
    {
        if(CutSceneManager.instance.is_First_CutScene)
        {
            Debug.Log("실행됨");
            anim.SetTrigger("isStart_First_CutScene");
        }
        if(CutSceneManager.instance.is_Second_CutScene)
        {
            anim.SetTrigger("isSatrt_Second_CutScene");
        }
        if(CutSceneManager.instance.is_Thrid_CutScene ==true)
        {
            anim.SetTrigger("isStart_Thrid_CutScene");
        }
    }
    public void WalkUpAnim()
    {
        anim.SetTrigger("isWakeUp");
    }

    public void WalkUpMove()
    {
        anim.SetTrigger("isWakeUp2");
        this.gameObject.transform.localPosition = new Vector2 (-317.24f, -239.126f);
    }
    public void WalkUP_Move3()
    {
        anim.SetTrigger("isWakeUp3");
        this.gameObject.transform.localPosition = new Vector2 (-317.73f, -239.87f);
    }
}
