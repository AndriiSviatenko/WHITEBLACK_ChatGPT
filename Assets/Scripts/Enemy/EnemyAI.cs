using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private VisionCone visionCone;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform[] patrolPoints;

    private int currentPointIndex;

    private void Update()
    {
        Patrol();
        visionCone.CheckForPlayer();
    }

    private void Patrol()
    {
        if (patrolPoints.Length == 0) return;

        Transform target = patrolPoints[currentPointIndex];
        transform.position = 
            Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        }
    }
}
