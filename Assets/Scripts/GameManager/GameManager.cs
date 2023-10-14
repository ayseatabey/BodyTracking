using UnityEngine;

namespace Born.InterviewTest.GameManager
{
    public class GameManager : MonoBehaviour
    {
      
      
        
        public GameObject trackedBodyPrefab;


        void Start()
        {
            Instantiate(trackedBodyPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}