using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1llvl : MonoBehaviour
{
    public PlayerController Player;
    public List<GameObject> Enemies;
    public int enemyCount;
    public int enemyForce;

    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.tag == "Enemy1lvl")
            {
             //   Debug.Log("Enemy");
                Enemies.Add(child.gameObject);
            }
        }
        enemyCount = Enemies.Count;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Player.countOn > enemyCount)
            {
                Debug.Log("enemy-");

                Player.TurnOffFromEnemy(enemyCount);
                EnemyMinus(enemyCount);
                Player.scores = Player.scores - enemyForce;
            }
            else if (Player.countOn < enemyCount)
            {
                Debug.Log("enemy+");
                Player.scores = 140;
                Time.timeScale = 0;
            }

        }
    }
    private void EnemyMinus(int num)
    {
        for (int i = 0; i < num; i++)
        {
            if (Enemies[i].activeSelf)
            {
                Enemies[i].SetActive(false);
            }
        }
    }
}
