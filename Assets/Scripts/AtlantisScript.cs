using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtlantisScript : MonoBehaviour
{
    private Canvas FinishCanvas;

    private void Start()
    {
        FinishCanvas = CameraMovement.Instance.GetFinishCanvas();
        if (!FinishCanvas)
        {
            Debug.LogError("FinishCanvas not found!");
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0f;
            FinishCanvas.gameObject.SetActive(true);
        }
    }


}
