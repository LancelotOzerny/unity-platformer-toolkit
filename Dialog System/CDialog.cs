using System.Collections.Generic;
using UnityEngine;

public class CDialog : MonoBehaviour
{
    [SerializeField] private List<CDialogMessage> messages;

    /// <summary>
    /// Сообщения диалога
    /// </summary>
    public List<CDialogMessage> Messages 
    {  
        get 
        { 
            return messages; 
        } 
    }
}
