using UnityEngine;
using UnityEngine.Events;

public class CDialogMessage : MonoBehaviour
{
    [Tooltip("Сообщение игрока")]
    [SerializeField][TextArea] private string message;

    [Tooltip("Серия сообщений, которая будет выводиться игроку после в ответ на сообщение")]
    [SerializeField][TextArea] private string[] touches;

    [Tooltip("Событие, которое будет вызываться до начала вызова сообщения")]
    [SerializeField] private UnityEvent eventBefore;

    [Tooltip("Событие, которое будет вызываться после окончания вызова сообщения")]
    [SerializeField] private UnityEvent eventAfter;
}
