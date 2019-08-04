using UnityEngine;

public class MaterialApplier
{
    /// <summary>
    /// variable to store the reference of Object, whom texture will be applied
    /// </summary>
    private MeshRenderer backGroundMeshRender, TopPlaneMeshRender, BottonRightPlaneMeshRender, BottonLeftPlaneMeshRender;

    /// <summary>
    /// While creating object of this class objects mesh render reference should be pass
    /// </summary>
    public MaterialApplier(MeshRenderer bGMeshR, MeshRenderer TopPlaneMeshR, MeshRenderer BottonRightPlaneMeshR, MeshRenderer BottonLeftPlaneMeshR)
    {
        backGroundMeshRender = bGMeshR;
        TopPlaneMeshRender = TopPlaneMeshR;
        BottonRightPlaneMeshRender = BottonRightPlaneMeshR;
        BottonLeftPlaneMeshRender = BottonLeftPlaneMeshR;
    }

    /// <summary>
    /// This function will apply the texture to the planes
    /// </summary>
    public void render(Texture texture1, Texture texture2, Texture texture3, Texture texture4)
    {
        backGroundMeshRender.material.mainTexture = texture1;
        TopPlaneMeshRender.material.mainTexture = texture2;
        BottonRightPlaneMeshRender.material.mainTexture = texture3;
        BottonLeftPlaneMeshRender.material.mainTexture = texture4;
    }
}
