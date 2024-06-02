using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class BTN : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public BtnType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    bool isSound;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BtnType.Start:
                Debug.Log("����");
                break;
            case BtnType.Option:
                Debug.Log("����");
                break;
            case BtnType.Sound:
                if (isSound)
                {
                    isSound = !isSound;
                    Debug.Log("�Ҹ���");
                }
                else
                {
                    Debug.Log("�Ҹ���");
                }
                break;
            case BtnType.Back:
                Debug.Log("�ڷΰ���");
                break;
        }
    }
    
    public void CanvasGroupon(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
