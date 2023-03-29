using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    private int playerScore = 0;
    private SaveManager saveManager;

    void Start() {
        saveManager = FindObjectOfType<SaveManager>();
        playerScore = saveManager.LoadGame();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.B)) {
            playerScore++;
            print("Player Score Has Been Increased");
        }

        if (Input.GetKeyDown(KeyCode.N)) {
            saveManager.SaveGame(playerScore);
            print("Score Has Been Saved");
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            playerScore = saveManager.LoadGame();
            print($"Last Saved Score: {playerScore}");
        }
    }
}