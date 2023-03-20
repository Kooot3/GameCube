using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraPlayer : MonoBehaviour
    {
        public GameObject player;
        private Vector3 offset;

        private void Start()
        {
            offset = transform.position;
        }

        private void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}