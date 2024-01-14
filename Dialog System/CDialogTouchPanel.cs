using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CDialogTouchPanel : MonoBehaviour
{
    [SerializeField] private Text touchText;
    [SerializeField] private List<string> elements = new List<string>();
    [SerializeField] private UnityEvent eventAfter;

    [SerializeField] private float timer = 4f;
    private float timerInterval;

    private void Start()
    {
        timerInterval = timer;
    }

    private void Update()
    {
        if (elements.Count == 0)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            Next();
        }
    }

    public void Next()
    {
        timer = timerInterval;
        elements.RemoveAt(0);

        if (elements.Count == 0)
        {
            eventAfter.Invoke();
            return;
        }

        touchText.text = elements[0];
    }

    public void AddTouch(CDialogMessage message)
    {
        message.eventBefore.Invoke();

        foreach (string touch in message.touches)
        {
            elements.Add(touch);
        }

        if (elements.Count != 0)
        {
            touchText.text = elements[0];
        }
    }
}
