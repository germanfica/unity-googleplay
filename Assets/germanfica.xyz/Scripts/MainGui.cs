using GooglePlayGames;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

namespace xyz.germanfica.googleplay {
    public class MainGui : MonoBehaviour {
        public Text message;

        void Start() {
            message.text = "Bienvenidos a M2";
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            GooglePlayGames.PlayGamesPlatform.DebugLogEnabled = true;
            PlayGamesPlatform.Activate();
        }
        
        public void Authentication() {
            Social.localUser.Authenticate((bool success) => {
                if (success) {
                    message.text = "Welcome " + Social.localUser.userName;
                }
                else {
                    message.text = "Authentication failed.";
                }
            });
        }

        public void ShowAchievments() {
            Social.ShowAchievementsUI();
        }

        public void Signout() {
            ((PlayGamesPlatform)Social.Active).SignOut();
        }
    }
}