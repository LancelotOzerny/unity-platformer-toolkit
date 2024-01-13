using UnityEngine;

public class CPlayer : CUnit
{
    private void Update()
    {
        MoveDirection = new Vector2
        (
            Input.GetAxisRaw("Horizontal"),    
            Input.GetAxisRaw("Vertical")
        );
    }
}
