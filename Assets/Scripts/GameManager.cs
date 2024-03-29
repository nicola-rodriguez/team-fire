using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public Transform levelBounds;
    public float chosenHeight = 1f;
    public int amountOfObjectives = 4;
    public int objectiveCount = 0;
    public int countOfPainted = 0;
    public int gamesWon = 0;

    void Awake()
    {
        // Singleton pattern
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject); // Ensure we don't destroy this object when loading a new scene
        }
        else if (singleton != this)
        {
            Object.Destroy(gameObject);
        }
    }
    public void Update()
    {

    }
}