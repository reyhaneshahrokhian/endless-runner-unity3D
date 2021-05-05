using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Score : MonoBehaviour
{
    public int count = 0;
    public int score = 0;
    public int HighScore;
    public Text scoreText;
    public Text HighText;
    public static Score inst;
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void increase()
    {
        count++;
        if (count == 50)
        {
            score++;
            count = 0;
            scoreText.text = "Score : " + score;
        }
        StreamReader reader = new StreamReader("Score.txt");
        HighScore = int.Parse(reader.ReadLine());
        reader.Close();

        HighText.text = "HighScore : " + HighScore;
        if (score > HighScore)
        {
            HighScore = score;
            HighText.text = "HighScore : " + HighScore;
            File.WriteAllText("Score.txt", string.Empty);
            StreamWriter writer = new StreamWriter("Score.txt");
            writer.WriteLine(HighScore);
            writer.Close();
        }
    }
}
