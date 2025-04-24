using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    public string sceneToLoad;  // Name of the scene to load (must be added to build settings)

    void OnTriggerEnter(Collider other)
    {
        // You can customize this condition to only respond to player or specific object
        if (other.CompareTag("Player"))  // Requires the capsule to be tagged as "Player"
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}