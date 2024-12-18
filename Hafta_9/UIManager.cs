using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public Sprite[] lifeSprites;
    public Image lifeImage;
    public GameObject gameOverPanel;


    PlayerMovement player;
    public int score;



    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        gameOverPanel.SetActive(false);
    }


    private void Update()
    {

        scoreText.text = "Score : " + score.ToString();

        for (int i = 0; i < lifeSprites.Length; i++)
        {
            if (i == player.life)
            {
                lifeImage.sprite = lifeSprites[i];
            }

        }

        if(player.isDead)
        {
            gameOverPanel.SetActive(true);
            StartCoroutine(GameOverFlickerRoutine());
        }

        if (player.isDead && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

    }

    IEnumerator GameOverFlickerRoutine()
    {
        while (true)
        {
            gameOverPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            yield return new WaitForSeconds(1f);
            gameOverPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = " ";
            yield return new WaitForSeconds(1f);

        }
    }



}
