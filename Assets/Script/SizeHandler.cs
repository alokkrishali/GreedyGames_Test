using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is responsible for zooming In/Out the planes while pressing +/- button
/// </summary>
public class SizeHandler : MonoBehaviour
{
    /// <summary>
    /// Reference of the object to scle up/down
    /// </summary>
    [SerializeField]
    Transform screenObject;

    [SerializeField]
    Text ScalePercent;

    Vector2 initialDimension;

    float objectArea = 0, ScalingXFactor, ScalingYFactor, ScalingFactor = 10;

    private void Start()
    {
        initialDimension = new Vector2(screenObject.localScale.x, screenObject.localScale.y);
        ScalingXFactor = screenObject.localScale.x / ScalingFactor;
        ScalingYFactor = screenObject.localScale.y / ScalingFactor;
        ScalePercent.text = percentageCalculator();
    }

    /// <summary>
    /// Reduce the size of the planes
    /// </summary>
    public void ZoomOut()
    {
        if (initialDimension.x <= screenObject.localScale.x)
            return;

        Vector2 newScale = new Vector2(screenObject.localScale.x + ScalingXFactor, screenObject.localScale.y + ScalingYFactor);
        screenObject.localScale = new Vector3(newScale.x, newScale.y, 1);
        ScalePercent.text = percentageCalculator();

    }

    /// <summary>
    /// Enlarge the size of the plane
    /// </summary>
    public void ZoomIn()
    {
        if (screenObject.localScale.x <= 0)
            return;

        Vector2 newScale = new Vector2(screenObject.localScale.x - ScalingXFactor, screenObject.localScale.y - ScalingYFactor);
        screenObject.localScale = new Vector3(newScale.x, newScale.y, 1);
        ScalePercent.text = percentageCalculator();
    }

    /// <summary>
    /// Calculate the percentage of the visible area
    /// </summary>
    /// <returns> string with plane size percentage </returns>
    string percentageCalculator()
    {
        return Mathf.RoundToInt(screenObject.localScale.x * 100 / initialDimension.x) + "% VISIBLE";
    }

    /// <summary>
    /// Load the main scene
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
