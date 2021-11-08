using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    [SerializeField] private Text messageDisplay;
    [SerializeField] private float tweenTime;

    private Queue<string> messages = new Queue<string>();

    private void OnEnable()
    {
        Bonus.bonusObtain += bonusGot;
    }

    private void OnDisable()
    {
        Bonus.bonusObtain -= bonusGot;
    }

    private void Awake()
    {
        messageDisplay.rectTransform.localScale = new Vector3(0, 0, 0);
    }

    private void bonusGot(string obj)
    {
        messageDisplay.text = obj;
        messageDisplay.rectTransform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        messageDisplay.rectTransform.DOScale(0, tweenTime);

        messages.Enqueue(obj);
        Debug.Log("Current queue length: " + messages.Count.ToString());
    }

    private void Update()
    {
       // CheckQueue();
    }

    private void CheckQueue()
    {
        if (!DOTween.IsTweening(messageDisplay.rectTransform))
        {
            if (messages.Count > 0)
            {
                DisplayMessageAnimate(messages.Dequeue());
            }
        }
    }

    private void DisplayMessageAnimate(string obj)
    {
        messageDisplay.text = obj;
        messageDisplay.rectTransform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        messageDisplay.rectTransform.DOScale(0, tweenTime);
    }
}