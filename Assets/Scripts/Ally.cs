using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public int force;
    public int numAlly;
    public PlayerController Player;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Player.scores = Player.scores + force;
            Player.SetForfce();
            Player.countOn = Player.countOn + numAlly;
            for (int i = 0; i < numAlly; i++)
            {
                Player.TurnOnAlly();
            }
            //Destroy(gameObject, 0.2f);
            Debug.Log("DDieng");
        }
    }
}
