﻿using UnityEngine;
using System.Collections;

namespace DigitalRuby.RainMaker
{
    public class DemoScript : MonoBehaviour
    {
        public RainScript RainScript;
        public UnityEngine.UI.Slider RainSlider;
        // public GameObject Sun;

        private enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
        private RotationAxes axes = RotationAxes.MouseXAndY;
        private float sensitivityX = 15F;
        private float sensitivityY = 15F;
        private float minimumX = -360F;
        private float maximumX = 360F;
        private float minimumY = -60F;
        private float maximumY = 60F;
        private float rotationX = 0F;
        private float rotationY = 0F;
        private Quaternion originalRotation;

        private void UpdateRain()
        {
            if (RainScript != null)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    RainScript.RainIntensity = 0.0f;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    RainScript.RainIntensity = 0.2f;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    RainScript.RainIntensity = 0.5f;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    RainScript.RainIntensity = 0.8f;
                }
            }
        }

        private void UpdateMovement()
        {
            float speed = 5.0f * Time.deltaTime;

            if (Input.GetKey(KeyCode.W))
            {
                Camera.main.transform.Translate(0.0f, 0.0f, speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Camera.main.transform.Translate(0.0f, 0.0f, -speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Camera.main.transform.Translate(-speed, 0.0f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Camera.main.transform.Translate(speed, 0.0f, 0.0f);
            }
        }


        public void RainSliderChanged(float val)
        {
            RainScript.RainIntensity = val;
        }

    

        // public void DawnDuskSliderChanged(float val)
        // {
        //     Sun.transform.rotation = Quaternion.Euler(val, 0.0f, 0.0f);
        // }

        public void FollowCameraChanged(bool val)
        {
            RainScript.FollowCamera = val;
        }

        // Use this for initialization
        private void Start()
        {
            originalRotation = transform.localRotation;
            RainScript.RainIntensity = RainSlider.value = 0.5f;
            RainScript.EnableWind = true;
        }

        // Update is called once per frame
        private void Update()
        {
            UpdateRain();
            UpdateMovement();
        }

        public static float ClampAngle(float angle, float min, float max)
        {
            if (angle < -360F)
            {
                angle += 360F;
            }
            if (angle > 360F)
            {
                angle -= 360F;
            }

            return Mathf.Clamp(angle, min, max);
        }
    }
}