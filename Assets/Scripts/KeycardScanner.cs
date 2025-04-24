using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardScanner : MonoBehaviour
{
    public GameObject doorToMove;        // Assign door or object
    public GameObject requiredKeycard;   // The keycard GameObject to check
    public float moveDistance = 1f;      // How far the door moves down
    public float moveSpeed = 1f;         // Speed of door movement

    private bool doorShouldMove = false;
    private Vector3 targetPosition;

    void OnTriggerEnter(Collider other)
    {
        // Only trigger if the correct keycard is placed
        if (other.gameObject == requiredKeycard)
        {
            if (doorToMove != null)
            {
                targetPosition = doorToMove.transform.position - Vector3.up * moveDistance;
                doorShouldMove = true;
            }
        }
    }

    void Update()
    {
        if (doorShouldMove && doorToMove != null)
        {
            doorToMove.transform.position = Vector3.MoveTowards(
                doorToMove.transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );

            if (doorToMove.transform.position == targetPosition)
            {
                doorShouldMove = false;
            }
        }
    }
}