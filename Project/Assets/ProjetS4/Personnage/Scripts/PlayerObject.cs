using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer == false)
        {
            return;
        }
        //Instantiate(PlayerUnitPrefab);
        //NetworkServer.Spawn(PlayerUnitPrefab);
        CmdSpawnMyUnit();
    }


    public GameObject PlayerUnitPrefab;

    [SyncVar]
    public string PlayerName = "Anonymous";

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer == false)
        {
            return;
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdMoveUnitUp();
        }*/

        /*if ( Input.GetKeyDown(KeyCode.Q) )
        {
            string n = "Quill" + Random.Range(1, 100);

            Debug.Log("Sending the server a request to change our name to : " + n);
            CmdChangePlayerName(n);
        }*/
    }

    GameObject myPlayerUnit;

    [Command]
    void CmdSpawnMyUnit()
    {
        GameObject go = Instantiate(PlayerUnitPrefab);

        myPlayerUnit = go;

        //go.GetComponent<NetworkIdentity>().AssignClientAuthority(connectionToClient);

        NetworkServer.SpawnWithClientAuthority(go, connectionToClient);
    }

    /*[Command]
    void CmdMoveUnitUp()
    {
        if (myPlayerUnit == null)
        {
            return;
        }


        myPlayerUnit.transform.Translate(0, 1, 0);
    }*/

    [Command]
    void CmdChangePlayerName(string n)
    {
        Debug.Log("CmdChangePlayerName : " + n);
        PlayerName = n;

       // RpcChangePlayerName(PlayerName);
    }

    /*[ClientRpc]
    void RpcChangePlayerName(string n)
    {
        Debug.Log("RpcChangePlayerName : We were asked to change the player name on a particular PlayerObject : " + n);
        PlayerName = n;
    }*/
}
