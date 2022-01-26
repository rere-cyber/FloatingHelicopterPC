using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private float _speed = 0.1f;

    private Vector2 _savedPos;

    private void Awake()
    {
        if (meshRenderer == true)
        {
            _savedPos = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
        }

    }
    private void Update()
    {
        Move(meshRenderer, _savedPos, _speed);
    }


    private void Move(MeshRenderer _mesh, Vector2 _savedOffset, float _speed)
    {
        Vector2 offset = Vector2.zero;
        float tmp = Mathf.Repeat(Time.time * _speed, 1);
        offset = new Vector2(tmp, _savedOffset.y);
        _mesh.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}

