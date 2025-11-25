using UnityEngine;

/// <summary>
/// Base class for any 2D object the player can interact with:
/// signs, lock panel, doors, NPCs, etc.
/// </summary>
public abstract class Interactable2D : MonoBehaviour
{
    [TextArea]
    public string promptText = "Press E";

    public abstract void Interact(PlayerInteraction2D player);
}
