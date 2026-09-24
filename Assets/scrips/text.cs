using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class text : MonoBehaviour
{
    public TextMeshProUGUI txt;
    int score = 0;
    private void Awake()
    {
        Player2.addScore += Score;
        
    }
    private void Start()
    {
        Score(0);
    }

    private void OnDisable()
    {
        Player2.addScore -= Score;

    }

    public void Score(int addscore) {
        score += addscore;

        txt.text = $"Score: {score}";
    
    }

}
