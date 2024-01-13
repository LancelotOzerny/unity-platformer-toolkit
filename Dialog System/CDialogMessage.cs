using UnityEngine;
using UnityEngine.Events;

public class CDialogMessage : MonoBehaviour
{
    [Tooltip("��������� ������")]
    [SerializeField][TextArea] private string message;

    [Tooltip("����� ���������, ������� ����� ���������� ������ ����� � ����� �� ���������")]
    [SerializeField][TextArea] private string[] touches;

    [Tooltip("�������, ������� ����� ���������� �� ������ ������ ���������")]
    [SerializeField] private UnityEvent eventBefore;

    [Tooltip("�������, ������� ����� ���������� ����� ��������� ������ ���������")]
    [SerializeField] private UnityEvent eventAfter;
}
