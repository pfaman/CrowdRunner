using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Name")]
    [SerializeField] private CrowdSystem crowdSystem;


    [Header("Settings")]
    [SerializeField] float moveSpead;
    [SerializeField] float roadWidth;

    [Header("Controls")]
    [SerializeField] float slideSpeed;
    private Vector3 clickedScreenPosition;
    private Vector3 clickedPlayerPosition;


    // Start is called before the first frame update
    void Start()
    {
        crowdSystem = GetComponent<CrowdSystem>();   
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        ManageControl();
    }
    private void MoveForward()
    {
        transform.position += Vector3.forward * moveSpead * Time.deltaTime;
    }

    private void ManageControl()
    {
        if(Input.GetMouseButtonDown(0))
        {

            clickedScreenPosition = Input.mousePosition;
            clickedPlayerPosition = transform.position;
        }
        else if(Input.GetMouseButton(0))
        {
            float xScreenDiff = Input.mousePosition.x - clickedScreenPosition.x;

            xScreenDiff /= Screen.width;

            xScreenDiff *= slideSpeed;

            Vector3 position = transform.position;

            position.x = clickedPlayerPosition.x + xScreenDiff;

            position.x = Mathf.Clamp(position.x, -roadWidth / 2 + crowdSystem.GetCrowdRadius(), roadWidth / 2- crowdSystem.GetCrowdRadius());

            transform.position = position;
        }
    }

}
