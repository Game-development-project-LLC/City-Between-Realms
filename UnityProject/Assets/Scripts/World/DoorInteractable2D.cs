
using UnityEngine;

/// <summary>
/// Gate door that blocks the exit until the correct code is entered.
/// Interact() can show a hint; Open() is called by Level1PuzzleManager.
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class DoorInteractable2D : Interactable2D
{
    private Collider2D doorCollider;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        doorCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void Interact(PlayerInteraction2D player)
    {
        UIManager.Instance.ShowInfo("The gate is locked. Maybe the control panel can open it.");
    }

    public void Open()
    {
        if (doorCollider != null)
            doorCollider.enabled = false;

        if (spriteRenderer != null)
            spriteRenderer.enabled = false;

        Debug.Log("Gate door opened.");
    }
}
