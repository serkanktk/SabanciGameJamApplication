using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject background;
    public GameObject player;

    public float score;
    public TextMeshProUGUI scoreText;

    public List<Texture2D> textureList;

    public GameObject spaceshipSprite;
    public GameObject birdbackSprite;
    public GameObject machineSprite;
    public GameObject underseaMachine;

    public Canvas phaseTwoCanvas;
    public Canvas phaseThreeCanvas;
    public Canvas phaseFourCanvas;




    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        List<Texture2D> textureList = new List<Texture2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }



        if(((int)score) == 35)
        {
            Renderer renderer = background.GetComponent<Renderer>();
            if (renderer != null && textureList.Count > 0)
            {
                renderer.material.mainTexture = textureList[0];
                spaceshipSprite.SetActive(false);
                birdbackSprite.SetActive(true);

                phaseTwoCanvas.gameObject.SetActive(true);


            }
        }
        else if (((int)score) == 40)
        {
            phaseTwoCanvas.gameObject.SetActive(false);
        }
        else if (((int)score) == 75)
        {
            Renderer renderer = background.GetComponent<Renderer>();
            if (renderer != null && textureList.Count > 0)
            {
                renderer.material.mainTexture = textureList[1];
                birdbackSprite.SetActive(false);
                machineSprite.SetActive(true);

                phaseThreeCanvas.gameObject.SetActive(true);
            }
        }
        else if (((int)score) == 80)
        {
            phaseThreeCanvas.gameObject.SetActive(false);
        }
        else if (((int)score) == 115)
        {
            Renderer renderer = background.GetComponent<Renderer>();
            if (renderer != null && textureList.Count > 0)
            {
                renderer.material.mainTexture = textureList[2];
                machineSprite.SetActive(false);
                underseaMachine.SetActive(true);

                phaseFourCanvas.gameObject.SetActive(true);
            }
        }
        else if (((int)score) == 120)
        {
            phaseFourCanvas.gameObject.SetActive(false);
        }
    }
}
