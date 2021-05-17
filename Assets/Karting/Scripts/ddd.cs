using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ddd : MonoBehaviour
{
    static ddd _instance;
    public static int stage = 1;
    public static int coin = 0;
    // Use this for initialization
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void setStage(int a)
    {
        stage = a;
    }

    public int getStage()
    {
        return stage;
    }
}