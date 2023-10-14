using Born.InterviewTest.BodyTracking;
using UnityEngine;
using Joint = Born.InterviewTest.BodyTracking.Joint;

namespace Born.InterviewTest.ControlledDevice
{
    /// <summary>
    /// Turns the attached object into a reference for the controlled device to follow.
    /// The system responsible for controlling the device needs to simulate rotating the controlled device
    /// according to the rotation of the object this behaviour is attached to.
    /// </summary>
    public class ControlledDeviceInput : MonoBehaviour
    {
        public Transform hostObject;

        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            if (TrackedBody.Instance)
            {
                var headPosition = TrackedBody.Instance.GetJointPose(Joint.Head);
                var directionVector = (headPosition.position - hostObject.position).normalized;
                var targetRotation = Quaternion.LookRotation(directionVector);
                hostObject.rotation = Quaternion.Slerp(hostObject.rotation, targetRotation, Time.deltaTime);
            }
        }
    }
}