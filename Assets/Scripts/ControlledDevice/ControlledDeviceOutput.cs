using UnityEngine;

namespace Born.InterviewTest.ControlledDevice
{
    /// <summary>
    /// Turns the attached object into an actual representation of the controlled device.
    /// This needs to apply the rotation value retrieved from the device to the attached object so that we can observe
    /// the device rotation on the scene.
    /// </summary>
    public class ControlledDeviceOutput : MonoBehaviour
    {
        private void Update()
        {
            UpdateRotation();
        }

        private void UpdateRotation()
        {
            // Complete this method to rotate this object as per the rotation data imagined to be received 
            // from the controlled device.
        }
    }
}
