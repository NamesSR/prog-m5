using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class m5prog : MonoBehaviour
{
    public string naam = "seb";
    public int score = 1000;
    public bool alive = true;
    public int health = 100;
    int i = 0;
    int[] damage = new int[2] { 35, 80 };
    string[] enemys = new string[5] { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };
    int[] highscores = new int[5] { 10000, 6793, 16829, 252000, 59828 };
    int highscore = 0;
    public player[] players = new player[3];
    public List<string> enemyList = new List<string>();
    public GameObject tower;
    public player player;
    public player player2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("-------------------opdracht 1.1-------------------");
        Debug.Log($"Name: {naam}");
        Debug.Log($"Score: {score}");
        Debug.Log($"Alive: {alive}");
        Debug.Log("-------------------opdracht 1.3-------------------");
        Begroet(naam);
        Debug.Log("-------------------opdracht 1.4-------------------");
        Debug.Log($"result : {Max(50, 75)}");
        Debug.Log($"result : {Max(60, 59)}");
        Debug.Log($"result : {Max(50, 50)}");
        Debug.Log($"result : {Max(837, 72)}");
        Debug.Log("-------------------opdracht 1.5-------------------");
        Debug.Log($"damage : {CalcDamage(650, 200)}");
        Debug.Log($"damage : {CalcDamage(650, 800)}");
        Debug.Log($"damage : {CalcDamage(749, 564)}");
        Debug.Log("-------------------opdracht 1.6-------------------");
        for (int i = 0; i < enemys.Length; i++)
        {
            Debug.Log(enemys[i]);
        }
        Debug.Log("-------------------opdracht 1.7-------------------");
        for (int j = 0; j < highscores.Length; j++)
        {

            if (highscores[j] > highscore)
            {
                highscore = highscores[j];
            }
            
        }
        Debug.Log($"highscore: {highscore}");
        Debug.Log("-------------------opdracht 1.8-------------------");
        
        player.naam = "mario";
        player.hp = 25;
        player.score = 500;
        player2.naam = "link";
        player2.hp = 50;
        player2.score = 200;
        player.printdata();
        player2.printdata();
        Debug.Log("-------------------opdracht 1.9-------------------");
        player.vertel();
        player2.vertel();
        Debug.Log("-------------------opdracht 1.10-------------------");
        for(int i = 0;i < players.Length; i++)
        {
            players[i].printdata();
        }
        Debug.Log("-------------------opdracht 1.11-------------------");
        for (int i = 0; i < enemys.Length; i++)
        {
            enemyList.Add(enemys[i]);
        }
        enemyList.Remove(enemys[0]);
        foreach(string s in enemyList)
        {
            Debug.Log(s);
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("-------------------opdracht 1.2-------------------");
            
            
                if(i > 1)
                {
                    i = 0;
                }

                health -= damage[i];
                i++;
            if(health < 1)
            {
                Debug.Log($"HP : 0");
                Debug.Log("Player is dead");

            }
            else
            {
                Debug.Log($"HP : {health}");
                Debug.Log("Player is still alive");

            }
            


        }
        if (Input.GetKeyDown(KeyCode.E))
        {
           Instantiate(tower);
           
        }

    }

    void Begroet(string naam)
    {
        Debug.Log("welkom " + naam + "!");
    }
    int Max(int a, int b)
    {
        if (a > b) return a;
        if(b > a) return b;
        if (a == b)
        {
            Debug.Log("a and b are the same size");
            return a;
        }
        return 0;
    }
    int CalcDamage(int damage, int defense)
    {
        if(damage - defense < 1)
        {
            return 0;
        }
        else
        {
            return damage - defense;
        }
    }
}
