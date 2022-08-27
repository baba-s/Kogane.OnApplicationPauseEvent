using UnityEngine;

namespace Kogane.Internal
{
    [AddComponentMenu( "" )]
    [DisallowMultipleComponent]
    internal sealed class OnApplicationPauseEventComponent : MonoBehaviour
    {
        public event OnApplicationPauseEvent.OnApplicationPauseDelegate OnPause;

        private void OnApplicationPause( bool pauseStatus )
        {
            OnPause?.Invoke( pauseStatus );
        }
    }
}