using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public Transform levelBounds;

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
            this.levelBounds = singleton.levelBounds;
            Object.Destroy(gameObject);
        }
    }
    public void Update()
    {

    }
}