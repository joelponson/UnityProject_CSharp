using UnityEngine;
using UnityEngine.Networking;

public class HostGame : MonoBehaviour {

    [SerializeField]
    private uint roomSize = 6;

    private string rootName;

    private NetworkManager networkManager;

    void Start ()
    {
        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetRootName (string _name)
    {
        rootName = _name;
    }

    public void CreateRoom ()
    {
        if (rootName != "" && rootName != null)
        {
            Debug.Log("Creating Room: " + rootName + " with room for " + roomSize + " players");

            //Create room
            networkManager.matchMaker.CreateMatch(rootName, roomSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
        }
    }

}
