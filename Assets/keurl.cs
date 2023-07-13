using UnityEngine;

public class keurl : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL (Url);
    }
}
