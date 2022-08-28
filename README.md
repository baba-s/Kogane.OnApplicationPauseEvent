# Kogane On Application Pause Event

OnApplicationPause をどこからでも設定できるようにするパッケージ

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        OnApplicationPauseEvent.OnApplicationPause += status => Debug.Log( status );
    }
}
```