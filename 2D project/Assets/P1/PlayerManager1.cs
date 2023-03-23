using UnityEngine;

public class PlayerManager1 : MonoBehaviour
{
    //declare and set a variable for health
    public int maxHealth = 5;
    public int currentHealth;
    
    PlayerMovement1 playerMovement;
    public int coinCount;

    private void Awake()
    {
        currentHealth = 3;
        playerMovement = GetComponent<PlayerMovement1>();
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            PauseGame();
        }

    }
    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Currency":
                coinCount++;
                return true;
            case "Speed+":
                playerMovement.SpeedPowerUp();
                return true;
            default:
                return false;
        }
    }
    // pause / stop our game when we need to
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    //create a function that will damage our player
    public void TakeDamage()
    {
        currentHealth-=1;
    }
}
