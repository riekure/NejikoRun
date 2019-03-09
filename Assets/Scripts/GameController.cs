using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public NejikoController nejiko;
    public TextAlignment scoreLabel;
    public LifePanel lifePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // スコアラベルを更新
        int score = CalcScore();
        scoreLabel.text = "Score ： " + score + "m";
    }

    int CalcScore()
    {
        // ねじ子の走行距離をスコアとする
        return (int)nejiko.transform.position.z;
    }
}
