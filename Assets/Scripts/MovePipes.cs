using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    [SerializeField]
    private float _pipeSpeed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * _pipeSpeed * Time.deltaTime);
    }
}
