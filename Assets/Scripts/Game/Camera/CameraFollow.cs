using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneCore
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] Transform target;
        Vector3 distance;
        void Start()
        {
            distance = transform.position - target.position;
        }


        void Update()
        {
            transform.position = target.position + distance;
        }
    }

}
