using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private int score;
    [SerializeField] private int taskScore = 3;
    [SerializeField] private int health;

    [Header("Events")]
    public UnityEvent addEnemyEvent;
    public UnityEvent removeEnemyEvent;

    public void AddScore(int addScore)
    {
        score += addScore;
    }

    public int GetScore()
    {
        return score;
    }
    
    public void AddHealth(int addHealth)
    {
        health += addHealth;
    }

    public int GetHealth()
    {
        return health;
    }
    
    public int GetTaskScore()
    {
        return taskScore;
    }
    

    public void LoadLevel(string nameLevel)
    {
        SceneManager.LoadScene(nameLevel);
    }
}
