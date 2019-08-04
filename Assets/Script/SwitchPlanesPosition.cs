using UnityEngine;

/// <summary>
/// Use to swap position of two object
/// </summary>
public class SwitchPlanesPosition : MonoBehaviour
{
    /// <summary>
    /// planes top/bottom pos
    /// </summary>
    [SerializeField]
    Vector2 topPlanePos, bottomTopPos;

    [SerializeField]
    Transform holder_1, holder_2;

    void Start()
    {
        holder_1.localPosition = new Vector3(topPlanePos.x, topPlanePos.y,-1);
        holder_2.localPosition = new Vector3(bottomTopPos.x, bottomTopPos.y, -1);
    }

    /// <summary>
    /// Switch the pos of the plane holder
    /// </summary>
    public void SwitchPlanePos()
    {
        Vector3 tempPos = holder_1.localPosition;
        holder_1.localPosition = holder_2.localPosition;
        holder_2.localPosition = tempPos;
    }

    /// <summary>
    /// load main Scene
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
