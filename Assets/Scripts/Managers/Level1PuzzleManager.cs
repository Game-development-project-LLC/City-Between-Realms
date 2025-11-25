
using UnityEngine;

/// <summary>
/// Level 1 puzzle: checks if the code entered in the lock panel is correct.
/// If the code is correct, opens the gate door.
/// </summary>
public class Level1PuzzleManager : MonoBehaviour
{
    public static Level1PuzzleManager Instance { get; private set; }

    [Header("Correct code as string (e.g. \"257\")")]
    public string correctCode = "257";

    [Header("Door to open when code is correct")]
    public DoorInteractable2D gateDoor;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void TrySolve(string enteredCode)
    {
        if (enteredCode == correctCode)
        {
            Debug.Log("Correct code! Door opens.");
            UIManager.Instance.ShowInfo("The gate unlocks.");
            gateDoor?.Open();
            UIManager.Instance.CloseLockPanel();
        }
        else
        {
            Debug.Log("Wrong code.");
            UIManager.Instance.ShowInfo("Wrong code. Maybe check the sign again.");
        }
    }
}
