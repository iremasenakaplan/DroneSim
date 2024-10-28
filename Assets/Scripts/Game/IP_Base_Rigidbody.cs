using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneCore
{
    [RequireComponent(typeof(Rigidbody))]
    public class IP_Base_Rigidbody : MonoBehaviour
    {
        [Header("Rigidbody Properties")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbsToKg = 0.454f;
        protected Rigidbody rb;
        protected float startDrag;
        protected float startAngularDrag;
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if(rb)
            {
                rb.mass = weightInLbs * lbsToKg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }


        void FixedUpdate()
        {
            if(!rb)
            {
                return;
            }

            HandlePhysics();
        }

        protected virtual void HandlePhysics()
        {

        }
    }

}

