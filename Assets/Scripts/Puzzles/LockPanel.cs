using UnityEngine;

/// <summary>
/// Control panel near the gate.
/// When the player interacts with it, it shows some info
/// and opens the lock UI (code input).
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class LockPanel : Interactable2D
{
    [TextArea]
    public string panelInfoText =
        "This panel controls the gate. It requires a 3-digit code.";

    private void Reset()
    {
        var col = GetComponent<Collider2D>();
        col.isTrigger = true;
    }

    public override void Interact(PlayerInteraction2D player)
    {
        UIManager.Instance.ShowInfo(panelInfoText);
        UIManager.Instance.OpenLockPanel();
    }
}
