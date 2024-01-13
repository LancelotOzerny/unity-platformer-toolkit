using UnityEngine;
using UnityEngine.Events;

public class CNPC : CUnit
{
    [SerializeField] private bool playerNear = false;

    [SerializeField] private UnityEvent playerEnter = null;
    [SerializeField] private UnityEvent playerExit = null;
    [SerializeField] private UnityEvent playerNearClick = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNear = true;

            if (playerEnter != null)
            {
                playerEnter.Invoke();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerNear = false;

            if (playerExit != null)
            {
                playerExit.Invoke();
            }
        }
    }

    private void OnMouseUp()
    {
        if (playerNear && playerNearClick != null)
        {
            playerNearClick.Invoke();
        }
    }
}
