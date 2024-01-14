using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CDialogMessage
{
    [Tooltip("��������� ������")]
    [TextArea] public string message;

    [Tooltip("����� ���������, ������� ����� ���������� ������ ����� � ����� �� ���������")]
    [TextArea] public List<string> touches;

    [Tooltip("�������, ������� ����� ���������� �� ������ ������ ���������")]
    public UnityEvent eventBefore;

    [Tooltip("�������, ������� ����� ���������� ����� ��������� ������ ���������")]
    public UnityEvent eventAfter;
}