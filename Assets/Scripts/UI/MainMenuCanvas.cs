using Platformer.Model;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Platformer.UI
{
    public class MainMenuCanvas : MonoBehaviour
    {
        [SerializeField] private TMP_InputField inputUsername;
        [SerializeField] private Button btnPlay;

        private static MainMenuCanvas _instance;
        public static MainMenuCanvas Instance => _instance;

        void Awake()
        {
            if (_instance == null) _instance = this;

            inputUsername.onValueChanged.AddListener(OnUsernameInputChanged);
            inputUsername.text = GameDatabase.Instance.CurrentUser.Username;
        }
        private void Update()
        {
            ChangeState();
        }

        private void OnDestroy()
        {
            inputUsername.onValueChanged.RemoveListener(OnUsernameInputChanged);
        }
        private void ChangeState()
        {
            if (inputUsername.text.Trim() != "")
                btnPlay.interactable = true;
            else
                btnPlay.interactable = false;
        }

        #region Event Handlers

        private void OnUsernameInputChanged(string newName)
        {
            GameDatabase.Instance.SetUsername(newName);
            ChangeState();
        }

        public void BtnPlayClicked()
        {
            if (inputUsername.text.Trim() != "")
            {
                SceneManager.LoadScene("Assets/Scenes/LevelScene.unity", LoadSceneMode.Single);
                return;
            }
            Debug.Log("You must enter an username to play the game!");
        }
        
        #endregion Event Handlers
    }
}