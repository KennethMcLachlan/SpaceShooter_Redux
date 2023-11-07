using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMain : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    private bool _isEnemyLaser;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);

        if (transform.position.x >= 21.0f)
        {
            Destroy(gameObject);
        }
    }
}
