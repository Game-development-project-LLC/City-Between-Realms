using UnityEngine;
using TMPro;

/// <summary>
/// Shows or hides this object (and its children) depending on the realm.
/// Works with SpriteRenderer, TMP_Text and Collider2D.
/// No events – RealmManager calls UpdateForRealm() on all of these when realm changes.
/// </summary>
public class RealmObjectToggle2D : MonoBehaviour
{
    public bool showInFantasy = true;
    public bool showInFuture = false;

    private SpriteRenderer[] spriteRenderers;
    private TMP_Text[] tmpTexts;
    private Collider2D[] colliders;

    private void Awake()
    {
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>(true);
        tmpTexts = GetComponentsInChildren<TMP_Text>(true);
        colliders = GetComponentsInChildren<Collider2D>(true);
    }

    private void Start()
    {
        // Set initial state according to the current realm
        if (RealmManager.Instance != null)
        {
            UpdateForRealm(RealmManager.Instance.CurrentRealm);
        }
    }

    /// <summary>
    /// Called by RealmManager whenever the realm changes.
    /// </summary>
    public void UpdateForRealm(RealmType realm)
    {
        bool show =
            (realm == RealmType.Fantasy && showInFantasy) ||
            (realm == RealmType.Future && showInFuture);

        foreach (var r in spriteRenderers)
            r.enabled = show;

        foreach (var t in tmpTexts)
            t.enabled = show;

        foreach (var c in colliders)
            c.enabled = show;
    }
}
