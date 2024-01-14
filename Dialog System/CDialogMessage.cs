using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CDialogMessage
{
    [Tooltip("Сообщение игрока")]
    [TextArea] public string message;

    [Tooltip("Серия сообщений, которая будет выводиться игроку после в ответ на сообщение")]
    [TextArea] public List<string> touches;

    [Tooltip("Событие, которое будет вызываться до начала вызова сообщения")]
    public UnityEvent eventBefore;

    [Tooltip("Событие, которое будет вызываться после окончания вызова сообщения")]
    public UnityEvent eventAfter;
}