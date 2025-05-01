using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 targetPosition;
    private bool isMoving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }

        if (isMoving)
        {
            Move();
        }
    }

    private void SetTarget(Vector3 target)
    {
        target.z = 0;
        targetPosition = target;
        isMoving = true;
    }

    private void Move()
    {
        transform.position = 
            Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }
}
