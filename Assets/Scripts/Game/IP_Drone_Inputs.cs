using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DroneCore
{
    [RequireComponent(typeof(PlayerInput))]
    public class IP_Drone_Inputs : MonoBehaviour
    {
        private Vector2 cyclic;
        private float pedals;
        private float throttle;

        public Vector2 Cyclic { get => cyclic; }
        public float Pedals { get => pedals; }
        public float Throttle { get => throttle; }

        void Update()
        {

        }

        private void OnCyclic(InputValue value)
        {
            Debug.Log("Cyclic Value is -> " + value.Get < Vector2 > ());
            cyclic = value.Get<Vector2>();
        }

        private void OnPedals(InputValue value)
        {
            Debug.Log("Pedal Value is -> " + value.Get<float>());
            pedals = value.Get<float>();
        }

        private void OnThrottle(InputValue value)
        {
            Debug.Log("Throttle Value is -> " + value.Get<float>());
            throttle = value.Get<float>();
        }
    }

}

