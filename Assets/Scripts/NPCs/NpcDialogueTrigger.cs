
using UnityEngine;

/// <summary>
/// Simple NPC trigger in the café.
/// For now it just prints a hint to the console when you press E near the NPC.
/// Later you can connect this to a dialogue UI.
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class NpcDialogueTrigger : Interactable2D
{
    [TextArea]
    public string dialogueText =
        "Strange... that sale sign looks different every night. " +
        "Maybe the code is hidden there.";

    public override void Interact(PlayerInteraction2D player)
    {
        Debug.Log(dialogueText);
        // TODO: send this text to UIManager to display on screen.
    }
}
