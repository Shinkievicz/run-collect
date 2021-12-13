using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snipers : MonoBehaviour
{
    float endTime = 0.2f;
    bool onOffShooting = true;

    public GameObject player;
    public Renderer rend;

    public float distance;
    //  public State Waiting;
    void Start()
    {
        rend = GetComponent<Renderer>();

    }
    // Update is called once per frame
    void Update()
    {
        Shooting(0.2f);

    }
    void Shooting(float t)
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 20)
        {
            endTime -= Time.deltaTime;
            if (endTime <= 0)
            {
                endTime = t;
                onOffShooting = !onOffShooting;
            }

            if (onOffShooting)
            {
                rend.enabled = false;
            }
            else
            {
                rend.enabled = true;
            }
        }
    }
}
