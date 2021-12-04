using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public int force;
    public PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // void OnCollisionEnter(Collision collision)
   // {
   //       if (collision.gameObject.tag == "Player")
   //       {
   //         gameObject.SetActive(false);
   //         Player.scores = Player.scores + force;
   //         Player.SetForfce();
   //
   //         //Destroy(gameObject, 0.2f);
   //         Debug.Log("SSieng");
   //     }
   // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Player.scores = Player.scores + force;
            Player.SetForfce();
            Player.TutnOnAlly();
            //Destroy(gameObject, 0.2f);
            Debug.Log("DDieng");
        }
    }
}
