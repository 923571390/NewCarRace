using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] stars;
    void Start()
    {
        if (ddd.coin == 0) return;
        for (int i = 0; i < ddd.coin; i++)
        {
            stars[i].GetComponent<Button>().interactable = true;
        }
    }
    public void LoadLastScene()
    {
        Application.LoadLevel(ddd.stage + 2);
    }
    public void LoadThisScene()
    {
        Application.LoadLevel(ddd.stage + 3);
    }
}
