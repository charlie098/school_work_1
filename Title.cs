using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // ��Ŭ���Ǿ�����
            SceneManager.LoadScene("Main"); // Main scene �̵�
        }
    }

    private GUIStyle guiStyle = new GUIStyle();
    void OnGUI()
    {
        guiStyle.fontSize = 40; // Font size ����
        guiStyle.normal.textColor = Color.red; // Font color ����
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "Title", guiStyle); // ȭ�鿡 'title'�̶�� ǥ��.
    }

}