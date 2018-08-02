using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text ScoreLabel;
    public GameObject ClearObject;
    public GameObject TitleButton;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Pick up").Length;
        ScoreLabel.text = count.ToString();

        if (count == 0)
        {
            // オブジェクトをアクティブにする
            ClearObject.SetActive(true);
            TitleButton.SetActive(true);
        }
    }
}