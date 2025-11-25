using UnityEngine;

/// <summary>
/// Detects Interactable2D objects via trigger colliders.
/// When the player is inside a trigger and presses E,
/// Interact() is called on that object.
/// Also talks to UIManager to show/hide the "Press E" prompt.
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class PlayerInteraction2D : MonoBehaviour
{
    private Interactable2D currentTarget;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentTarget != null)
        {
            currentTarget.Interact(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var interactable = other.GetComponent<Interactable2D>();
        if (interactable != null)
        {
            currentTarget = interactable;
            UIManager.Instance?.ShowPrompt(interactable.promptText);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var interactable = other.GetComponent<Interactable2D>();
        if (interactable != null && interactable == currentTarget)
        {
            currentTarget = null;

            // Hide "Press E" prompt
            UIManager.Instance?.HidePrompt();

            // Clear info text (for signs / messages)
            UIManager.Instance?.ClearInfo();

            // NEW: if we left the lock panel area, close the big white panel
            if (interactable is LockPanel)
            {
                UIManager.Instance?.CloseLockPanel();
            }
        }
    }

}
