using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    public float score = 0;
    public int coinsCollected = 0;
    public int coinCost = 5;

    private float originalZPos;

    private void Start()
    {
        originalZPos = player.position.z;
    }

    void Update()
    {
        score = coinsCollected * coinCost -((player.position.z - originalZPos) / 10);
        scoreText.text = score.ToString("0");
    }

    public void plusOneCoin()
    {
        coinsCollected++;
    }
}
