using Unity.AI.Navigation.Editor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class player : MonoBehaviour
{
    public string naam;
    public int hp;
    public int score;
   
   public void printdata()
    {
        Debug.Log($"Player.name : {naam}");
        Debug.Log($"Player.HP : {hp}");
        Debug.Log($"Player.Score : {score}");
    }

    public void vertel()
    {
        Debug.Log($"ik ben {naam} mijn HP is {hp} en mijn score is {score}");
    }
}
