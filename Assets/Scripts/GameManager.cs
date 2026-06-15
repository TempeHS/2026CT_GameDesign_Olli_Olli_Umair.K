using UnityEngine;

public class GameManager : MonoBehaviour
{
    int Score; 

    public text ScoreText;
    string ScoreFormat = "{0, 5:00000}";

    private void Awake()
    {
        Score = 0;
        ScoreText.text = string.Format(ScoreFormat, Score);
    }

    void CollectableCollected()
    {
        Score += 25;
    }
}
