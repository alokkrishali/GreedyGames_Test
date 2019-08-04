using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Perform three type of animation
/// </summary>
public class AnimationPlayer : MonoBehaviour
{
    /// <summary>
    /// This will give option to choose type of animation
    /// </summary>
    [SerializeField]
    Dropdown animationType;

    /// <summary>
    /// Reference of Animator to perform animation
    /// </summary>
    [SerializeField]
    Animator animator;

    /// <summary>
    /// Name of the animation State
    /// </summary>
    string animType = "FadeInOut";

    void Start()
    {
        animationType.onValueChanged.AddListener(delegate {
            myDropdownValueChangedHandler(animationType);
        });
    }

    /// <summary>
    /// Play animation of the selected Animation type
    /// </summary>
    public void PlayAnimation()
    {
        animator.SetTrigger(animType);
    }

    /// <summary>
    /// Assign the animation state on changing the animation state
    /// </summary>
    /// <param name="animationList"> drop down list </param>
    void myDropdownValueChangedHandler(Dropdown animationList)
    {
        switch(animationList.value)
        {
            case 0:
                animType = "FadeInOut";
                break;
            case 1:
                animType = "Rotation";
                break;
            case 2:
                animType = "Zoom";
                break;
        }
    }

    /// <summary>
    /// load main scene
    /// </summary>
    public void GoToMainScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        }
    }

}
