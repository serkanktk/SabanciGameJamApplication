using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    public static CameraMovement Instance; // Singleton instance

    [SerializeField] private Canvas finishCanvas;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public Canvas GetFinishCanvas()
    {
        return finishCanvas;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, cameraSpeed * Time.deltaTime, 0);
    }
}
