using UnityEngine;
using UnityEngine.SceneManagement;

namespace HogwartsLab.Menu
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField]
        private Animator _UIAnimator;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StartLab()
        {
            _UIAnimator.SetTrigger(Constants.MenuStartTrigger);
        }

        public void OpenHogwartsLab()
        {
            SceneManager.LoadScene(Constants.HogwartsLabScene);
        }
    }
}