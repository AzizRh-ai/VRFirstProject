using UnityEngine;

public class ControlVRorInput : MonoBehaviour
{

    [SerializeField] private GameObject XR;
    [SerializeField] private GameObject FakeInput;
    private bool isOnXRDevice = false;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            isOnXRDevice = true;
        }
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            isOnXRDevice = false;
        }
        XR.SetActive(isOnXRDevice);
        FakeInput.SetActive(!isOnXRDevice);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
