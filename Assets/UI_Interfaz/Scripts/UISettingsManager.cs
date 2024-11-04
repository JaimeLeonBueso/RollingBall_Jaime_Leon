using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

namespace SlimUI.ModernMenu
{
	public class UISettingsManager : MonoBehaviour
	{


		[Header("GAME SETTINGS")]
		public GameObject showhudtext;
		public GameObject tooltipstext;
		public GameObject difficultynormaltext;
		public GameObject difficultynormaltextLINE;
		public GameObject difficultyhardcoretext;
		public GameObject difficultyhardcoretextLINE;

		[Header("CONTROLS SETTINGS")]
		public GameObject invertmousetext;

		// sliders
		public GameObject musicSlider;
		private float sliderValue = 0.0f;


		public void Start()
		{



			musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");


			if (PlayerPrefs.GetInt("ShowHUD") == 0)
			{
				showhudtext.GetComponent<TMP_Text>().text = "off";
			}
			else
			{
				showhudtext.GetComponent<TMP_Text>().text = "on";
			}

			if (PlayerPrefs.GetInt("ToolTips") == 0)
			{
				tooltipstext.GetComponent<TMP_Text>().text = "off";
			}
			else
			{
				tooltipstext.GetComponent<TMP_Text>().text = "on";
			}




			void MusicSlider()
			{
				PlayerPrefs.SetFloat("MusicVolume", musicSlider.GetComponent<Slider>().value);
			}


			void ShowHUD()
			{
				if (PlayerPrefs.GetInt("ShowHUD") == 0)
				{
					PlayerPrefs.SetInt("ShowHUD", 1);
					showhudtext.GetComponent<TMP_Text>().text = "on";
				}
				else if (PlayerPrefs.GetInt("ShowHUD") == 1)
				{
					PlayerPrefs.SetInt("ShowHUD", 0);
					showhudtext.GetComponent<TMP_Text>().text = "off";
				}
			}

			void ToolTips()
			{
				if (PlayerPrefs.GetInt("ToolTips") == 0)
				{
					PlayerPrefs.SetInt("ToolTips", 1);
					tooltipstext.GetComponent<TMP_Text>().text = "on";
				}
				else if (PlayerPrefs.GetInt("ToolTips") == 1)
				{
					PlayerPrefs.SetInt("ToolTips", 0);
					tooltipstext.GetComponent<TMP_Text>().text = "off";
				}
			}
		}
	}
}


	

	