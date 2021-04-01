using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour
{
    public Text score;
    public Text life;

    public static int lifeValue = 5;
    public static int scoreValue = 0;
    public static bool ballIsDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + scoreValue.ToString();
        life.text = "Ball : " + lifeValue.ToString();
    }
}
