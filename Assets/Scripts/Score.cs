using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    private void Awake()
    {
        score = 0;
    }
    private void FixedUpdate()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}

