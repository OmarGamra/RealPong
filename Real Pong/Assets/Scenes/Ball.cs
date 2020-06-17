using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public TextMeshProUGUI ScoreRightText;
    public TextMeshProUGUI ScoreLeftText;
    int ScoreRight;
    int ScoreLeft;
    public float speed;

    // Update is called once per frame
    void Start()
    {
        ScoreRight = 0;
        ScoreLeft = 0;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    

    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            float y = HitFactor(transform.position,
               col.transform.position,
               col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.name == "RacketRight")
        {
            float y = HitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "WallRight")
        {
            ScoreLeft++;
            ScoreLeftText.text = ScoreLeft.ToString();
        }


        if (col.gameObject.name == "WallLeft")
        {
            ScoreRight++;
            ScoreRightText.text = ScoreRight.ToString();
        }
    }

}