# Endless Runner
 
To run the game please download the latest build in the release section, extract it and run the .exe

While this was the first game that I ever made the code that I wrote for the audio slider was very good and I have gone back and used it in other projects aswell as it works very well.

    using UnityEngine;
    using UnityEngine.Audio;
    using UnityEngine.UI;
    
    public class VolumeSettings : MonoBehaviour
    {
        [SerializeField] private AudioMixer Master;
        [SerializeField] private Slider musicSlider;
    
        private void Start()
        {
            if (PlayerPrefs.HasKey("musicVolume"))
            {
                LoadVolume();
            }
            else
            {
                SetMusicVolume();
            }
    
            // Add listener to update volume when slider value changes
            musicSlider.onValueChanged.AddListener(delegate { SetMusicVolume(); });
        }
    
        public void SetMusicVolume()
        {
            float volume = musicSlider.value;
    
            // Prevent Log10 errors by ensuring volume is above zero
            if (volume <= 0.0001f)
            {
                Master.SetFloat("music", -80f); // Minimum volume (mute)
            }
            else
            {
                Master.SetFloat("music", Mathf.Log10(volume) * 20); // Logarithmic volume scaling
            }
    
            PlayerPrefs.SetFloat("musicVolume", volume);
        }
    
        private void LoadVolume()
        {
            musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
    
            SetMusicVolume();
        }
    }
