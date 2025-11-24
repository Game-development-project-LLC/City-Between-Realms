using System;
using UnityEngine;

/// <summary>
/// Manages the current realm (Fantasy / Future) and the current day.
/// The Sleep button calls GoToSleep().
/// </summary>
public enum RealmType
{
    Fantasy,
    Future
}

public class RealmManager : MonoBehaviour
{
    public static RealmManager Instance { get; private set; }

    public RealmType CurrentRealm { get; private set; } = RealmType.Fantasy;
    public int CurrentDay { get; private set; } = 1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    /// <summary>
    /// Called by the Sleep button in the UI.
    /// </summary>
    public void GoToSleep()
    {
        CurrentDay++;
        SwitchRealm();
    }

    private void SwitchRealm()
    {
        CurrentRealm = (CurrentRealm == RealmType.Fantasy)
            ? RealmType.Future
            : RealmType.Fantasy;

        Debug.Log($"Day {CurrentDay}, realm switched to: {CurrentRealm}");

        // NEW: update all realm-toggled objects
        var toggles = FindObjectsOfType<RealmObjectToggle2D>(true);
        foreach (var t in toggles)
        {
            t.UpdateForRealm(CurrentRealm);
        }
    }
}
