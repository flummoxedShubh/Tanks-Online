using System.Threading.Tasks;
using UnityEngine;

public class ClientSingleton : MonoBehaviour
{
    private static ClientSingleton instance;
    public static ClientSingleton Instance
    {
        get
        {
            if (instance != null) return instance;

            instance = FindFirstObjectByType<ClientSingleton>();
            if(instance != null)
            {
                return instance;
            }
            else
            {
                Debug.LogError("No Client Singleton in the scene.");
                return null;
            }
        }
    }
    private ClientGameManager gameManager;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public async Task CreateClient()
    {
        gameManager = new ClientGameManager();
        await gameManager.InitAsync();
    }
}
