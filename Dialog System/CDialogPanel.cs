using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class CDialogPanel : MonoBehaviour
{
    [SerializeField] private GameObject messages;
    [SerializeField] private GameObject messagePref;
    private List<GameObject> messageObjects = new List<GameObject>();

    [SerializeField] private GameObject touch;

    [SerializeField] private CDialog dialog;

    [SerializeField] private CDialogMessage endMessage = null;

    [SerializeField] private CDialogTouchPanel touchPanel = null;

    private void Start()
    {
        Close();
    }

    /// <summary>
    /// Свойство, которое позволяет задать или получить диалог для отображения
    /// </summary>
    public CDialog Dialog 
    { 
        get 
        { 
            return dialog; 
        }
        set 
        {
            dialog = value; 
        }
    }

    public void Close()
    {
        messages.gameObject.SetActive(false);
        touch.gameObject.SetActive(false);
        this.dialog = null;
    }

    public void Display(CDialog dialog)
    {
        this.dialog = dialog;

        foreach (GameObject obj in messageObjects)
        {
            Destroy(obj);
        }

        messageObjects.Clear();
        messages.gameObject.SetActive(true);

        foreach (CDialogMessage message in Dialog.Messages)
        {
            AddMessage(message);    
        }

        if (endMessage != null)
        {
            AddMessage(endMessage);
        }
    }

    private void AddMessage(CDialogMessage message)
    {
        GameObject messageObj = Instantiate(messagePref, messages.transform);
        messageObj.GetComponent<Text>().text = message.message;
        messageObjects.Add(messageObj);
        messageObj.GetComponent<Button>().onClick.AddListener(() =>
        {
            messages.gameObject.SetActive(false);
            touchPanel.gameObject.SetActive(true);
            touchPanel.AddTouch(message);
        });
    }
}