using System.Threading.Tasks;
using UnityEngine;

public class HostSingleton : MonoBehaviour
{
    private static HostSingleton instance;
    public static HostSingleton Instance
    {
        get
        {
            if (instance != null) return instance;

            instance = FindFirstObjectByType<HostSingleton>();
            if(instance != null)
            {
                return instance;
            }
            else
            {
                Debug.LogError("No Host Singleton in the scene.");
                return null;
            }
        }
    }
    private HostGameManager gameManager;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void CreateHost()
    {
        gameManager = new HostGameManager();
    }
}
