using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class MoveObjectDown : MonoBehaviour
{
    public XRBaseInteractable vrButton;  // Assign your button in the Inspector
    public GameObject objectToMove;      // Assign the object to move
    public float moveDistance = 0.2f;    // How far down the object should move
    public float moveSpeed = 1f;         // Speed of movement

    private bool shouldMove = false;
    private Vector3 targetPosition;

    void Start()
    {
        if (vrButton != null)
        {
            vrButton.selectEntered.AddListener(OnButtonPressed);
        }
    }

    void OnButtonPressed(SelectEnterEventArgs args)
    {
        if (objectToMove != null)
        {
            targetPosition = objectToMove.transform.position - Vector3.up * moveDistance;
            shouldMove = true;
        }
    }

    void Update()
    {
        if (shouldMove && objectToMove != null)
        {
            objectToMove.transform.position = Vector3.MoveTowards(
                objectToMove.transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );

            if (objectToMove.transform.position == targetPosition)
            {
                shouldMove = false;
            }
        }
    }
}