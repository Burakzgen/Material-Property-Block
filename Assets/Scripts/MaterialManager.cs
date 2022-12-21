using UnityEngine;


public class MaterialManager : MonoBehaviour
{
    [SerializeField] Material _material;
    //[SerializeField] Color color_1, color_2;
    [SerializeField] MeshRenderer cubeMesh, sphereMesh;

    private void Start()
    {
        PropertyController();
    }
    public void OnClickButton()
    {
        PropertyController();
    }
    private void PropertyController()
    {
        MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();

        #region CUBE
        cubeMesh.sharedMaterial = _material;
        cubeMesh.GetPropertyBlock(propertyBlock);
        propertyBlock.SetColor("_Color", SetColor());
        cubeMesh.SetPropertyBlock(propertyBlock);
        #endregion

        #region SPHERE
        sphereMesh.sharedMaterial = _material;
        sphereMesh.GetPropertyBlock(propertyBlock);
        propertyBlock.SetColor("_Color", SetColor());
        sphereMesh.SetPropertyBlock(propertyBlock);
        #endregion
    }
   
    private Color SetColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 255f);
    }
}
