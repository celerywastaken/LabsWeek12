using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlatformTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        string platforminfo = "This project is running";

#if UNITY_EDITOR
        platforminfo += "In the editor.";
#elif UNITY_WEBGL
        platforminfo += "on the web.";
#else
        platforminfo += "as a build.";

#endif

        text.text = platforminfo;

    }

   
}
