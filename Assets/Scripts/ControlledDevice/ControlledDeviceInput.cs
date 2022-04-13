using UnityEngine;

namespace Born.InterviewTest.ControlledDevice
{
    /// <summary>
    /// Turns the attached object into a reference for the controlled device to follow.
    /// The system responsible for controlling the device needs to simulate rotating the controlled device
    /// according to the rotation of the object this behaviour is attached to.
    /// </summary>
    public class ControlledDeviceInput : MonoBehaviour
    {
        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            // Complete this method to rotate this object towards Joint.Head of a TrackedBody.
        }
    }
}
