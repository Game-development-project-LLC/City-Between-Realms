using UnityEngine;

/// <summary>
/// A sign that gives the player a hint about the password.
/// When the player is inside the trigger and presses E,
/// the hint is shown in the InfoText UI.
/// </summary>

[RequireComponent(typeof(Collider2D))]
public class SignPasswordHint2D : Interactable2D
{
    [TextArea]
    public string hintMessage = "Part of the code is...";

    private void Reset()
    {
        var col = GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    public override void Interact(PlayerInteraction2D player)
    {
        UIManager.Instance.ShowInfo(hintMessage);
    }
}

