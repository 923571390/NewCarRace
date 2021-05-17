using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public Selectable defaultSelection;
    public Button[] btns;
    public GameObject[] locks;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);

        int c = ddd.stage;
        for (int i = 0; i < 3; i++)
        {
            if ((i + 1) < c) unLock(i);
            else Lock(i);
        }
    }

    void LateUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (Input.GetButtonDown(GameConstants.k_ButtonNameSubmit)
                || Input.GetAxisRaw(GameConstants.k_AxisNameHorizontal) != 0
                || Input.GetAxisRaw(GameConstants.k_AxisNameVertical) != 0)
            {
                EventSystem.current.SetSelectedGameObject(defaultSelection.gameObject);
            }
        }
    }

    public void unLock(int i)
    {
        btns[i].GetComponent<Button>().interactable = true;
        locks[i].SetActive(false);
    }

    public void Lock(int i)
    {
        btns[i].GetComponent<Button>().interactable = false;
        locks[i].SetActive(true);
    }

    public void Reset()
    {
        ddd.stage = 1;
    }

}
