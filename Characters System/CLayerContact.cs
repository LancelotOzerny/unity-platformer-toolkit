using UnityEngine;

public class CLayerContact : MonoBehaviour
{
    [Header("Layer Check Params")]
    [SerializeField] private LayerMask layer;
    [SerializeField] private Vector2 offset;
    [SerializeField] private float radius = .5f;
    [SerializeField] private bool isContacted;
    
    /// <summary>
    /// Свойство, которое позволяет получить соприкосновение с установленным слоем
    /// Если соприкосновение происходит, то возвращается true, иначе false
    /// </summary>
    public bool IsContacted
    { 
        get => GetContacted(); 
    }

    private bool GetContacted()
    {
        Vector2 pos = new Vector2
        (
            transform.position.x + offset.x,
            transform.position.y + offset.y
        );

        Collider2D[] colliders = Physics2D.OverlapCircleAll(pos, radius, layer);
        
        return colliders.Length > 0;
    }

    private void OnDrawGizmosSelected()
    {
        Vector2 pos = new Vector2
        (
            transform.position.x + offset.x,
            transform.position.y + offset.y
        );

        Gizmos.DrawSphere(pos, radius);
        isContacted = GetContacted();
    }
}
