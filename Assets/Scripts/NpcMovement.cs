using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotationSpeed = 100f;
    public float detectionRadius = 2f;

    private bool isMoving = false;
    private Vector3 targetPosition;

    private void Start()
    {
        MoveToRandomPosition();
    }

    private void Update()
    {
        if (isMoving)
        {
            Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (!HasCollision(newPosition))
            {
                transform.position = newPosition;
            }
            else
            {
                MoveToRandomPosition();
            }

            if (transform.position == targetPosition)
            {
                isMoving = false;
                MoveToRandomPosition();
            }
        }
    }

    private void MoveToRandomPosition()
    {
        float range = 1000f;
        targetPosition = new Vector3(Random.Range(-range, range), 0f, Random.Range(-range, range));

        isMoving = true;
    }

    private bool HasCollision(Vector3 position)
    {
        Collider[] colliders = Physics.OverlapSphere(position, detectionRadius);
        foreach (Collider collider in colliders)
        {
            if (!collider.isTrigger && collider != GetComponent<Collider>())
            {
                return true;
            }
        }
        return false;
    }
}