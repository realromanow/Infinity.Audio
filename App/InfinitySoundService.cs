using Infinity.Audio.Api;
using UnityEngine;

namespace Infinity.Audio.App {
	public class InfinitySoundService : IInfinitySoundService {
		private readonly AudioSource _bgAudioSource;

		public InfinitySoundService (AudioSource bgAudioSource) {
			_bgAudioSource = bgAudioSource;
		}

		public void PauseBgSource () {
			_bgAudioSource.Pause();
		}

		public void UnPauseBgSource () {
			_bgAudioSource.UnPause();
		}
	}
}
