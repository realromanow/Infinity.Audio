using Infinity.Audio.App;
using Plugins.Infinity.DI.App;
using Plugins.Infinity.DI.Units;
using UnityEngine;

namespace Infinity.Audio.Units {
	[CreateAssetMenu(menuName = "Infinity/Units/InfinityAudioUnit", fileName = "InfinityAudioUnit")]
	public class InfinityAudioUnit : AppUnit {
		[SerializeField]
		private AudioClip _bgDefaultAudioClip;

		public override void SetupUnit (AppComponentsRegistry componentsRegistry) {
			base.SetupUnit(componentsRegistry);
			
			var audioSource = new GameObject("AudioSource").AddComponent<AudioSource>();
			audioSource.clip = _bgDefaultAudioClip;
			audioSource.playOnAwake = true;
			audioSource.Play();
			
			componentsRegistry.Instantiate<InfinitySoundService>(audioSource);
		}
	}
}
