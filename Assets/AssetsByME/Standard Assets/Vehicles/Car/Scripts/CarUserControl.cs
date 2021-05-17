using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public GameObject Hand; //仪表盘的针
        public Rigidbody Rigidbody { get; private set; }

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            Rigidbody = GetComponent<Rigidbody>();//获取刚体
        }


        private void FixedUpdate()
        {
            draw();
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }

        private void draw()
        {
            Hand.transform.rotation = Quaternion.AngleAxis((220 + 4 * Rigidbody.velocity.magnitude), Vector3.back);//仪表盘
        }
        //刚体speed *= 2.23693629f是仪表盘速度
    }
}
