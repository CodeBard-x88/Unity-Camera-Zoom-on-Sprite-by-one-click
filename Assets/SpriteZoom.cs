using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpriteZoom : MonoBehaviour
{
    [SerializeField]
    float verticalScaleFactor = 0.5f;

    [SerializeField]
    SpriteRenderer sprite;

    private void Start()
    {
        Camera.main.orthographicSize = sprite.bounds.size.y * verticalScaleFactor;
    }
}
