using Kogane.Internal;
using UnityEngine;

namespace Kogane
{
    public static class OnApplicationPauseEvent
    {
        public delegate void OnApplicationPauseDelegate( bool pauseStatus );

        private static OnApplicationPauseEventComponent m_component;

        public static event OnApplicationPauseDelegate OnApplicationPause
        {
            add => m_component.OnPause += value;
            remove => m_component.OnPause -= value;
        }

        [RuntimeInitializeOnLoadMethod( RuntimeInitializeLoadType.BeforeSceneLoad )]
        private static void RuntimeInitializeOnLoadMethod()
        {
            var gameObject = new GameObject( nameof( OnApplicationPauseEventComponent ) );

            m_component = gameObject.AddComponent<OnApplicationPauseEventComponent>();

            Object.DontDestroyOnLoad( gameObject );
        }
    }
}