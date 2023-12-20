
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        float yPositionInViewport = mainCamera.WorldToViewportPoint(transform.position).y;

        // Si l'objet est en dessous de la caméra
        if (yPositionInViewport < 0f)
        {
            // Détruire l'objet
            Destroy(gameObject);
        }
        
    }
}
