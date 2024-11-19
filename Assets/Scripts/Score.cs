using UnityEngine;
using UnityEngine.UI ;
public class Score : MonoBehaviour 
{
    public Text scoreText ;
    public Text FinalScore ;
    int myscore = 0 ;

    void Update()
    {
        scoreText.text = myscore.ToString();
        FinalScore.text = "Total Score: " + myscore.ToString() ;
    }

    public void Addscore(int score)
    {
        myscore = myscore + score ;
    }
}
