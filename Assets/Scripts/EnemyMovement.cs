using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;

    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private float speed = 3f;

    [SerializeField] private int startDirection = 1;

    private int currentDirection;

    private float halfWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        halfWidth = spriteRenderer.bounds.extents.x;
        currentDirection = startDirection;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidBody.linearVelocity = Vector2.right * speed * currentDirection;
    }
}
