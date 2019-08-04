using UnityEngine;

/// <summary>
/// Apply texture to the planes
/// </summary>
public class MaterialHandler : MonoBehaviour
{
    /// <summary>
    /// Reference of the plane, whom to apply texture
    /// </summary>
    [SerializeField]
    MeshRenderer backGroundMeshRender, TopPlaneMeshRender, BottonRightPlaneMeshRender, BottonLeftPlaneMeshRender;

    /// <summary>
    /// Reference of the textures
    /// </summary>
    [SerializeField]
    Texture planeTexture_1, planeTexture_2, planeTexture_3, planeTexture_4;

    /// <summary>
    /// C# script having render function to apply texture
    /// </summary>
    MaterialApplier matApp;

    void Start()
    {
        matApp = new MaterialApplier(backGroundMeshRender, TopPlaneMeshRender, BottonRightPlaneMeshRender, BottonLeftPlaneMeshRender);
    }

    /// <summary>
    /// Apply the texture to the objects
    /// </summary>
    public void ApplyTexture()
    {
        matApp.render(planeTexture_1, planeTexture_2, planeTexture_3, planeTexture_4);
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
