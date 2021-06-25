using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotate Propperty")]
    [SerializeField] Vector3 rotateDirection;
    [Range(-20f, 20f)][SerializeField] float rotateSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateDirection * rotateSpeed * Time.deltaTime);
    }
}
