using UnityEngine;
using Mirror;

public class AutoHostClient : MonoBehaviour
{
    [SerializeField] NetworkManager networkManager;

    public void join_local()
    {
        networkManager.networkAddress = "localhost";
        networkManager.StartClient();
    }
}
