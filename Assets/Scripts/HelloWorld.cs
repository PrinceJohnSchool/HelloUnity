// ============================================================================
// File:        HelloWorld.cs
// Author:      Prince John
// Project:     Hello Unity - GPE104 Project 1, Milestone 1
// Description: A custom C# component. When the component enters the game
//              world (its Start method runs), it prints "Hello World" to
//              the Unity Console debug window using Debug.Log. That is
//              the whole requirement - and the first script of the
//              course, so it is kept deliberately simple and readable.
// ============================================================================
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called when the component first enters the game world,
    // before the first frame update.
    private void Start()
    {
        // Print the greeting to the debug window (the Console).
        Debug.Log("Hello World");
    }
}

// Development-branch note: this comment was added on the development
// branch to demonstrate the branch -> change -> merge workflow for
// Milestone 2, then merged back into main.
