/*
David Huerta
GoalTrigger Script
Displays "You win!" text when player reaches goal.
*/

using UnityEngine;
using UnityEngine.UI;

public class GoalTrigger : MonoBehaviour
{
    public Text winText; // Reference to UI Text component

    void Start()
    {
        // Hide the text at the start
        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.text = "You Win!";
        }
    }
}
