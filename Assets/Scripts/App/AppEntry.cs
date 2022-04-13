using UnityEngine;

namespace Born.InterviewTest.App
{
    /// <summary>
    /// Provides an entry point for the application.
    /// This script's execution order is set to be before other scripts.
    /// Instantiates the <see cref="App"/> instance.
    /// </summary>
    public class AppEntry : MonoBehaviour
    {
        private App app;
        
        private void Awake()
        {
            app = new App();
            
            DontDestroyOnLoad(this);
        }
    }
}
