using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class DontDestroyOnLoadComponent : MonoBehaviour
	{
		private void Awake()
		{
			DontDestroyOnLoad( gameObject );
		}
	}
}