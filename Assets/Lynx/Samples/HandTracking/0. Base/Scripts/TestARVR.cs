/**
 * @file TestARVR.cs
 * 
 * @author Geoffrey Marhuenda
 * 
 * @brief Basic script to switch between AR and VR using a button.
 */

using lynx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace lynx
{
    public class TestARVR : MonoBehaviour
    {
        private int buttonCounter = 0;
        public Button button;
        private const string menuText1 = "Hi! My name is Milo.I will be your guide through the Multiverse. Let's begin exploring.";
        private const string menuText2 = "Everyone in this world is born with 9 magical abilities. Including you. Together we will go on an adventure to explore which of the 9 abilities is your strongest and how you can use it  to change the world.";
        private const string infoText = "?";
        private const string visualText = "You have a strong understanding of color, space, images and design and can visualize anything.";
        private const string verbalText = "You have a strong understanding of language and words, especially how to use words and what they mean.";
        private const string musicalText = "You have a strong understanding of rhythm and sound and are good at putting them together to create something nice to listen to.";
        private const string intraText = "You have a strong understanding of yourself, your needs, your values, your strengths and weaknesses.";
        private const string interText = "You have a strong understanding of people and their perspectives, needs, feelings and abilities and navigate them well.";
        private const string bodyText = "You have a strong understanding of how to control your movement and handle objects with skill and precision.";
        private const string natureText = "You have a strong understanding of how to categorize objects in your natural world and how they interact with one another.";
        private const string existText = "You can think deeply, wisely and thoroughly about questions regarding human existence, meaning of life and philosophy.";
        private const string logicalText = "You have a strong understanding of abstract ideas, cause and effect relationships and patterns within numbers and data.";
        public AudioSource onboardSound2;
        // public Button button;
        // private const string visualDefText = "you have a strong understanding of color, space, images and design and can visualize anything";

        public void SwitchDefn(TMPro.TMP_Text txt)
        {
            // Debug.Log("button clicked");
            if (txt.text.Equals(infoText))
            {
                if(button.tag == "visual")
                {
                    txt.text = visualText;
                }
                if(button.tag == "verbal")
                {
                    txt.text = verbalText;
                }
                if(button.tag == "musical")
                {
                    txt.text = musicalText;
                }
                if(button.tag == "logical")
                {
                    txt.text = logicalText;
                }
                if(button.tag == "exist")
                {
                    txt.text = existText;
                }
                if(button.tag == "intra")
                {
                    txt.text = intraText;
                }
                if(button.tag == "inter")
                {
                    txt.text = interText;
                }
                if(button.tag == "nature")
                {
                    txt.text = natureText;
                }
                if(button.tag == "body")
                {
                    txt.text = bodyText;
                }
                
                // LynxAPI.SetVR();
            }
            else
            {
                txt.text = infoText;
                // LynxAPI.SetAR();
            }
        }

        public void SwitchCol(TMPro.TMP_Text txt)
        {
            txt.color = new Color(1,0.2f,0.6f,1);
        }

        public void SwitchMenuText(TMPro.TMP_Text menu)
        {
            // int nextLevel = 0;
            buttonCounter++;

            if(buttonCounter==1)
            {
                menu.text = menuText2;
                onboardSound2.Play();
            }
            else if (buttonCounter>1)
            {
                // Debug.Log("scene change now");
                SceneManager.LoadScene("Self2");
                // SceneManager.LoadScene("Challenge");
                
            }

            // if (menu.text.Equals(menuText2))
            // {
            //     Debug.Log("scene change now");
            //     SceneManager.LoadScene("SelfSmart");
            //     // menu.text.enable = false;
            //     // panel.SetActive = false;
            //     // button.setActive = false;

            // }
        }

        public void SwitchtoScene(string sceneName)
        {
            
            SceneManager.LoadScene(sceneName);
                
        }

        // public void LoadChallenge()
        // {
        //     // if (col.gameObject.tag == "Player")
        //     // {
        //         SceneManager.LoadScene("Challenge");
        //     // }
        // }
        }
    }
