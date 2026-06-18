using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed = 3f;
    [SerializeField] private int startDirection = 1;

    private int currentDirection;
    private float halfWidth;
    private Vector2 movement;

    private void Start()
    {
        halfWidth = spriteRenderer.bounds.extents.x;
        currentDirection = startDirection;
    }

    private void FixedUpdate()
    {
        movement.x = speed * currentDirection;
        movement.y = rigidBody.linearVelocity.y; // <-- fixed
        rigidBody.linearVelocity = movement;

        SetDirection();
    }

    private void SetDirection()
    {
        Vector2 rayDirection = currentDirection > 0 ? Vector2.right : Vector2.left;
        Vector2 origin = (Vector2)transform.position + rayDirection * (halfWidth + 0.01f);
        float detectionDistance = 0.2f;

        if (Physics2D.Raycast(origin, rayDirection, detectionDistance, LayerMask.GetMask("Ground")))
        {
            currentDirection *= -1;
        }

        Debug.DrawRay(origin, rayDirection * detectionDistance, Color.red);
    }
}
