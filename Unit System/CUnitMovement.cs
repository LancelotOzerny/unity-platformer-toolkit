using UnityEngine;
using UnityEngine.Rendering;

public class CUnitMovement : CLayerContact
{
    [Header("Movement Params")]
    [SerializeField] protected float movementSpeed = 4f;
    [SerializeField] protected float jumpPower = 12f;
    private Rigidbody2D rb = null;

    public Vector2 MoveDirection 
    { 
        get; 
        protected set; 
    }

    public Vector2 Velocity 
    { 
        get => rb.velocity;
        protected set => rb.velocity = value;
    }

    protected void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected void FixedUpdate()
    {
        if (rb == null)
        {
            return;
        }

        Velocity = new Vector2(MoveDirection.x * movementSpeed, rb.velocity.y);

        if (MoveDirection.y > 0)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (rb == null)
        {
            return;
        }

        if (IsContacted)
        {
            Velocity = new Vector2(Velocity.x, jumpPower);
        }
    }
}
