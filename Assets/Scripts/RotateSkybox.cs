using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _speed);
    }
}
